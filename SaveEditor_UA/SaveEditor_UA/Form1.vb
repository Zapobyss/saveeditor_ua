Imports System.IO, System.Reflection

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    ' ################################################
    '
    ' File operation-related functions
    '
    ' ################################################


    ' Global variables
    Dim Savefile As FileStream ' The save file stream
    Dim Fsh As Byte() = {} ' To keep a copy of the opened save file in RAM


    ' Open the input save file, copy its data to RAM and close the input save file
    Private Sub OpenSavefile()

        Dim FilePrompt As New OpenFileDialog()

        FilePrompt.FileName = "mgFsh0.dat"
        FilePrompt.Filter = "Ultimate Angler / StreetPass Fishing save files (*.dat)|*.dat|All files (*.*)|*.*"
        FilePrompt.FilterIndex = 1
        FilePrompt.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        FilePrompt.RestoreDirectory = True
        FilePrompt.Title = "Select your save file."

        Select Case FilePrompt.ShowDialog()

            Case DialogResult.OK

                Try
                    Dim SelectedFileName As String = FilePrompt.FileName

                    Savefile = File.OpenRead(FilePrompt.FileName)

                    ' Obtain the variables from the input save file
                    GetProgressReportArrivalDate()
                    GetProgressReportInfo()

                    TextBox_CurrentFile_Path.Text = SelectedFileName
                    Label_CurrentFile_Size.Text = Savefile.Length.ToString()

                    ' Return to the beginning of the stream
                    ' and copy the entire save file into RAM
                    Savefile.Seek(0, SeekOrigin.Begin)

                    Dim SavefileSize As Integer = CInt(Savefile.Length)
                    Fsh = New Byte(SavefileSize - 1) {}
                    Savefile.Read(Fsh, 0, SavefileSize)

                    ' Close the input save file
                    Savefile.Close()

                    MsgBox("Save file opened successfully.", vbOKOnly + vbInformation, "Notice")

                Catch e As Exception
                    MsgBox(e.Message, vbOKOnly, "An exception occurred!")

                End Try

            Case DialogResult.Cancel
                'MsgBox("Cancel", vbOkOnly, "Notice")

            Case Else
                MsgBox("Either the file operation cancelled or an unexpected error occured.", vbOKOnly, "Unknown error")

        End Select

    End Sub


    ' Obtain and display the arrival date from the progress report in the Form
    Private Sub GetProgressReportArrivalDate()

        ' Local variables
        Dim YearBuffer(2) As Byte
        Dim MonthDayBuffer(1) As Byte


        ' Arrival Date
        ' Year (0x00000024 -> 0x00000025)
        Savefile.Seek(36, SeekOrigin.Begin) ' 0x00000024
        Savefile.Read(YearBuffer, 0, YearBuffer.Length)
        Dim ArrivalYear As UInt16 = BitConverter.ToUInt16(YearBuffer, 0)

        ' Month (0x00000026)
        Savefile.Seek(38, SeekOrigin.Begin) ' 0x00000026
        Savefile.Read(MonthDayBuffer, 0, 1)
        Dim ArrivalMonth As Short = BitConverter.ToInt16(MonthDayBuffer, 0)

        ' Day (0x00000027)
        Savefile.Seek(39, SeekOrigin.Begin) ' 0x00000027
        Savefile.Read(MonthDayBuffer, 0, 1)
        Dim ArrivalDay As Short = BitConverter.ToInt16(MonthDayBuffer, 0)


        DateTimePicker_Prog1.Value = New DateTime(ArrivalYear, ArrivalMonth, ArrivalDay)

    End Sub


    ' Obtain and show the information from the progress report in the Form
    Private Sub GetProgressReportInfo()

        ' Local variables
        Dim TempBuffer(3) As Byte


        ' Trips Taken (0x00000028 -> 0x0000002B)
        Savefile.Seek(40, SeekOrigin.Begin) ' 0x00000028
        Savefile.Read(TempBuffer, 0, TempBuffer.Length)
        Dim TripsTaken As UInteger = BitConverter.ToUInt32(TempBuffer, 0)
        NumUpDown_Prog3.Value = TripsTaken

        ' Treasure Chests Found (0x00002A28 -> 0x00002A2B)
        Savefile.Seek(10792, SeekOrigin.Begin) ' 0x00002A28
        Savefile.Read(TempBuffer, 0, TempBuffer.Length)
        Dim Treasure As UInteger = BitConverter.ToUInt32(TempBuffer, 0)
        NumUpDown_Prog5.Value = Treasure

        ' Anglers Met (0x00002AC4 -> 0x00002AC7)
        Savefile.Seek(10948, SeekOrigin.Begin) ' 0x00002AC4
        Savefile.Read(TempBuffer, 0, TempBuffer.Length)
        Dim AnglersMet As UInteger = BitConverter.ToUInt32(TempBuffer, 0)
        NumUpDown_Prog2.Value = AnglersMet

    End Sub

    ' Overwrite the offsets that contain the data
    Private Sub OverwriteOffsets()

        ' Local variables
        Dim Year As Short = DateTimePicker_Prog1.Value.Year
        Dim Month As Byte = DateTimePicker_Prog1.Value.Month
        Dim Day As Byte = DateTimePicker_Prog1.Value.Day

        Dim YearBuffer() As Byte = BitConverter.GetBytes(Year)
        Dim MonthBuffer() As Byte = {Month}
        Dim DayBuffer() As Byte = {Day}

        Dim TripsTaken As UInt32 = NumUpDown_Prog3.Value
        Dim Treasure As UInt32 = NumUpDown_Prog5.Value
        Dim AnglersMet As UInt32 = NumUpDown_Prog2.Value

        Dim TripsTakenBuffer() As Byte = BitConverter.GetBytes(TripsTaken)
        Dim TreasureBuffer() As Byte = BitConverter.GetBytes(Treasure)
        Dim AnglersMetBuffer() As Byte = BitConverter.GetBytes(AnglersMet)


        ' Arrival Date
        ' Year (0x00000024 -> 0x00000025)
        Savefile.Seek(36, SeekOrigin.Begin)
        Savefile.Write(YearBuffer, 0, YearBuffer.Length)

        ' Month (0x00000026)
        Savefile.Seek(38, SeekOrigin.Begin)
        Savefile.Write(MonthBuffer, 0, MonthBuffer.Length)

        ' Day (0x00000027)
        Savefile.Seek(39, SeekOrigin.Begin)
        Savefile.Write(DayBuffer, 0, DayBuffer.Length)


        ' Trips Taken (0x00000028 -> 0x0000002B)
        Savefile.Seek(40, SeekOrigin.Begin)
        Savefile.Write(TripsTakenBuffer, 0, TripsTakenBuffer.Length)

        ' Treasure Chests Found (0x00002A28 -> 0x00002A2B)
        Savefile.Seek(10792, SeekOrigin.Begin)
        Savefile.Write(TreasureBuffer, 0, TreasureBuffer.Length)

        ' Anglers Met (0x00002AC4 -> 0x00002AC7)
        Savefile.Seek(10948, SeekOrigin.Begin)
        Savefile.Write(AnglersMetBuffer, 0, AnglersMetBuffer.Length)

    End Sub

    ' Export the edited save file
    Private Sub ExportSavefile()

        Dim FileOut As New SaveFileDialog()

        FileOut.FileName = "mgFsh0.dat"
        FileOut.Filter = "Ultimate Angler / StreetPass Fishing save files (*.dat)|*.dat|All files (*.*)|*.*"
        FileOut.FilterIndex = 1
        FileOut.InitialDirectory = TextBox_CurrentFile_Path.Text
        FileOut.RestoreDirectory = True
        FileOut.Title = "Select the path where the modified save file will be exported."

        Select Case FileOut.ShowDialog()

            Case DialogResult.OK
                File.WriteAllBytes(FileOut.FileName, Fsh)

                ' Open the freshly saved save file and write the new offsets!
                Savefile = File.OpenWrite(FileOut.FileName)
                OverwriteOffsets()
                Savefile.Close()

                MsgBox("Changes applied!", vbOKOnly + vbInformation, "Success")

            Case DialogResult.Cancel
                'MsgBox("Cancel", vbOkOnly, "Notice")

            Case Else
                MsgBox("Either the file operation cancelled or an unexpected error occured.", vbOKOnly, "Unknown error")

        End Select

    End Sub

    ' ################################################
    '
    ' MenuStrip1 functions
    '
    ' ################################################

    Private Sub FileToolStrip_Open_mgFsh0_Click(sender As Object, e As EventArgs) Handles FileToolStrip_Open_mgFsh0.Click
        OpenSavefile()
    End Sub

    Private Sub FileToolStrip_Reset_Click(sender As Object, e As EventArgs) Handles FileToolStrip_Reset.Click

        ' Reset the variables from the Form
        DateTimePicker_Prog1.Value = New DateTime(2000, 1, 1)
        NumUpDown_Prog3.Value = 0
        NumUpDown_Prog5.Value = 0
        NumUpDown_Prog2.Value = 0

        TextBox_CurrentFile_Path.Text = ""
        Label_CurrentFile_Size.Text = "0"

        ' Clear the save file that was previously copied in RAM
        Fsh = {}

    End Sub

    Private Sub FileToolStrip_Exit_Click(sender As Object, e As EventArgs) Handles FileToolStrip_Exit.Click
        End
    End Sub

    Private Sub ExportToolStrip_ExportmgFsh0_Click(sender As Object, e As EventArgs) Handles ExportToolStrip_ExportmgFsh0.Click

        If Fsh.Length = Nothing Or Fsh.Length = 0 Then
            MsgBox("You either haven't opened a save file yet or the size doesn't match with what is expected.", vbOKOnly + vbInformation, "File size error")

        ElseIf Fsh.Length = 196256 Then

            If NumUpDown_Prog2.Value > 9999 Or NumUpDown_Prog3.Value > 9999 Or NumUpDown_Prog5.Value > 9999 Then

                Dim SizeWarning = MsgBox("One or more of the variables you've entered exceeded 9999. Although the game is programmatically able to display values beyond that, they will reset back to 9999 after a fishing session once the saving data process occurs." + vbNewLine + vbNewLine + "Are you sure you want to continue?", vbYesNo + vbExclamation, "Warning!")

                If SizeWarning = vbYes Then
                    ExportSavefile()
                End If

            Else
                ExportSavefile()
            End If

        End If

    End Sub

    Private Sub AboutToolStrip_QuickStart_Click(sender As Object, e As EventArgs) Handles AboutToolStrip_QuickStart.Click
        MsgBox("1.- Before everything, remember to have a backup! Data loss and corruption are possibilities and I am not liable if that happens." & vbNewLine & vbNewLine & "2.- Select your save file. It will be copied to RAM, and your original copy will be closed, rendering it intact. This tool has been tested with US and EUR save files." + vbNewLine + vbNewLine + "3.- Edit the data to your heart's content." + vbNewLine + vbNewLine + "4.- Export a new copy of the save file as 'mgFsh0.dat'.", vbOKOnly + vbInformation, "Quick start")
    End Sub

    Private Sub AboutToolStrip_SoftwareVersion_Click(sender As Object, e As EventArgs) Handles AboutToolStrip_SoftwareVersion.Click
        Dim ASMversion As Version = Assembly.GetExecutingAssembly().GetName().Version
        MsgBox("Save editor for Ultimate Angler / StreetPass Fishing" + vbNewLine + "Assembly version: " + ASMversion.ToString(), vbOKOnly, "Software version")
    End Sub

End Class