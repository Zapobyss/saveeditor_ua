<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label_InfoCurSave = New System.Windows.Forms.Label()
        Me.Label_InfoCurSaveSize = New System.Windows.Forms.Label()
        Me.Label_CurrentFile_Size = New System.Windows.Forms.Label()
        Me.GroupBox_SaveInfo = New System.Windows.Forms.GroupBox()
        Me.TextBox_CurrentFile_Path = New System.Windows.Forms.TextBox()
        Me.GroupBox_Variables = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker_Prog1 = New System.Windows.Forms.DateTimePicker()
        Me.NumUpDown_Prog5 = New System.Windows.Forms.NumericUpDown()
        Me.NumUpDown_Prog3 = New System.Windows.Forms.NumericUpDown()
        Me.NumUpDown_Prog2 = New System.Windows.Forms.NumericUpDown()
        Me.Label_Prog6 = New System.Windows.Forms.Label()
        Me.Label_Prog5 = New System.Windows.Forms.Label()
        Me.Label_Prog3 = New System.Windows.Forms.Label()
        Me.Label_Prog4 = New System.Windows.Forms.Label()
        Me.Label_Prog1 = New System.Windows.Forms.Label()
        Me.Label_Prog_2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStrip_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStrip_Open_mgFsh0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FileToolStrip_Reset = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStrip_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStrip_ExportmgFsh0 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStrip = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStrip_QuickStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStrip_SoftwareVersion = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox_SaveInfo.SuspendLayout()
        Me.GroupBox_Variables.SuspendLayout()
        CType(Me.NumUpDown_Prog5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUpDown_Prog3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumUpDown_Prog2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_InfoCurSave
        '
        Me.Label_InfoCurSave.AutoSize = True
        Me.Label_InfoCurSave.Location = New System.Drawing.Point(6, 43)
        Me.Label_InfoCurSave.Name = "Label_InfoCurSave"
        Me.Label_InfoCurSave.Size = New System.Drawing.Size(124, 13)
        Me.Label_InfoCurSave.TabIndex = 1
        Me.Label_InfoCurSave.Text = "Save file you've opened:"
        '
        'Label_InfoCurSaveSize
        '
        Me.Label_InfoCurSaveSize.AutoSize = True
        Me.Label_InfoCurSaveSize.Location = New System.Drawing.Point(6, 69)
        Me.Label_InfoCurSaveSize.Name = "Label_InfoCurSaveSize"
        Me.Label_InfoCurSaveSize.Size = New System.Drawing.Size(69, 13)
        Me.Label_InfoCurSaveSize.TabIndex = 3
        Me.Label_InfoCurSaveSize.Text = "Size in bytes:"
        '
        'Label_CurrentFile_Size
        '
        Me.Label_CurrentFile_Size.AutoSize = True
        Me.Label_CurrentFile_Size.Location = New System.Drawing.Point(133, 69)
        Me.Label_CurrentFile_Size.Name = "Label_CurrentFile_Size"
        Me.Label_CurrentFile_Size.Size = New System.Drawing.Size(13, 13)
        Me.Label_CurrentFile_Size.TabIndex = 4
        Me.Label_CurrentFile_Size.Text = "0"
        '
        'GroupBox_SaveInfo
        '
        Me.GroupBox_SaveInfo.Controls.Add(Me.TextBox_CurrentFile_Path)
        Me.GroupBox_SaveInfo.Controls.Add(Me.Label_InfoCurSave)
        Me.GroupBox_SaveInfo.Controls.Add(Me.Label_CurrentFile_Size)
        Me.GroupBox_SaveInfo.Controls.Add(Me.Label_InfoCurSaveSize)
        Me.GroupBox_SaveInfo.Location = New System.Drawing.Point(12, 263)
        Me.GroupBox_SaveInfo.Name = "GroupBox_SaveInfo"
        Me.GroupBox_SaveInfo.Size = New System.Drawing.Size(480, 106)
        Me.GroupBox_SaveInfo.TabIndex = 5
        Me.GroupBox_SaveInfo.TabStop = False
        Me.GroupBox_SaveInfo.Text = "Basic information about the selected save file"
        '
        'TextBox_CurrentFile_Path
        '
        Me.TextBox_CurrentFile_Path.Location = New System.Drawing.Point(136, 40)
        Me.TextBox_CurrentFile_Path.Name = "TextBox_CurrentFile_Path"
        Me.TextBox_CurrentFile_Path.ReadOnly = True
        Me.TextBox_CurrentFile_Path.Size = New System.Drawing.Size(324, 20)
        Me.TextBox_CurrentFile_Path.TabIndex = 6
        '
        'GroupBox_Variables
        '
        Me.GroupBox_Variables.Controls.Add(Me.DateTimePicker_Prog1)
        Me.GroupBox_Variables.Controls.Add(Me.NumUpDown_Prog5)
        Me.GroupBox_Variables.Controls.Add(Me.NumUpDown_Prog3)
        Me.GroupBox_Variables.Controls.Add(Me.NumUpDown_Prog2)
        Me.GroupBox_Variables.Controls.Add(Me.Label_Prog6)
        Me.GroupBox_Variables.Controls.Add(Me.Label_Prog5)
        Me.GroupBox_Variables.Controls.Add(Me.Label_Prog3)
        Me.GroupBox_Variables.Controls.Add(Me.Label_Prog4)
        Me.GroupBox_Variables.Controls.Add(Me.Label_Prog1)
        Me.GroupBox_Variables.Controls.Add(Me.Label_Prog_2)
        Me.GroupBox_Variables.Location = New System.Drawing.Point(12, 42)
        Me.GroupBox_Variables.Name = "GroupBox_Variables"
        Me.GroupBox_Variables.Size = New System.Drawing.Size(330, 204)
        Me.GroupBox_Variables.TabIndex = 7
        Me.GroupBox_Variables.TabStop = False
        Me.GroupBox_Variables.Text = "Progress Report"
        '
        'DateTimePicker_Prog1
        '
        Me.DateTimePicker_Prog1.Location = New System.Drawing.Point(157, 34)
        Me.DateTimePicker_Prog1.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker_Prog1.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker_Prog1.Name = "DateTimePicker_Prog1"
        Me.DateTimePicker_Prog1.Size = New System.Drawing.Size(152, 20)
        Me.DateTimePicker_Prog1.TabIndex = 1
        Me.DateTimePicker_Prog1.Tag = ""
        Me.DateTimePicker_Prog1.Value = New Date(2000, 1, 1, 0, 0, 0, 0)
        '
        'NumUpDown_Prog5
        '
        Me.NumUpDown_Prog5.Location = New System.Drawing.Point(157, 138)
        Me.NumUpDown_Prog5.Maximum = New Decimal(New Integer() {2139062143, 0, 0, 0})
        Me.NumUpDown_Prog5.Name = "NumUpDown_Prog5"
        Me.NumUpDown_Prog5.Size = New System.Drawing.Size(152, 20)
        Me.NumUpDown_Prog5.TabIndex = 4
        '
        'NumUpDown_Prog3
        '
        Me.NumUpDown_Prog3.Location = New System.Drawing.Point(157, 86)
        Me.NumUpDown_Prog3.Maximum = New Decimal(New Integer() {2139062143, 0, 0, 0})
        Me.NumUpDown_Prog3.Name = "NumUpDown_Prog3"
        Me.NumUpDown_Prog3.Size = New System.Drawing.Size(152, 20)
        Me.NumUpDown_Prog3.TabIndex = 3
        '
        'NumUpDown_Prog2
        '
        Me.NumUpDown_Prog2.Location = New System.Drawing.Point(157, 60)
        Me.NumUpDown_Prog2.Maximum = New Decimal(New Integer() {2139062143, 0, 0, 0})
        Me.NumUpDown_Prog2.Name = "NumUpDown_Prog2"
        Me.NumUpDown_Prog2.Size = New System.Drawing.Size(152, 20)
        Me.NumUpDown_Prog2.TabIndex = 2
        '
        'Label_Prog6
        '
        Me.Label_Prog6.AutoSize = True
        Me.Label_Prog6.Location = New System.Drawing.Point(17, 166)
        Me.Label_Prog6.Name = "Label_Prog6"
        Me.Label_Prog6.Size = New System.Drawing.Size(106, 13)
        Me.Label_Prog6.TabIndex = 10
        Me.Label_Prog6.Text = "Rod Types Collected"
        '
        'Label_Prog5
        '
        Me.Label_Prog5.AutoSize = True
        Me.Label_Prog5.Location = New System.Drawing.Point(17, 140)
        Me.Label_Prog5.Name = "Label_Prog5"
        Me.Label_Prog5.Size = New System.Drawing.Size(117, 13)
        Me.Label_Prog5.TabIndex = 9
        Me.Label_Prog5.Text = "Treasure Chests Found"
        '
        'Label_Prog3
        '
        Me.Label_Prog3.AutoSize = True
        Me.Label_Prog3.Location = New System.Drawing.Point(17, 88)
        Me.Label_Prog3.Name = "Label_Prog3"
        Me.Label_Prog3.Size = New System.Drawing.Size(64, 13)
        Me.Label_Prog3.TabIndex = 4
        Me.Label_Prog3.Text = "Trips Taken"
        '
        'Label_Prog4
        '
        Me.Label_Prog4.AutoSize = True
        Me.Label_Prog4.Location = New System.Drawing.Point(17, 114)
        Me.Label_Prog4.Name = "Label_Prog4"
        Me.Label_Prog4.Size = New System.Drawing.Size(108, 13)
        Me.Label_Prog4.TabIndex = 8
        Me.Label_Prog4.Text = "Group Catches Made"
        '
        'Label_Prog1
        '
        Me.Label_Prog1.AutoSize = True
        Me.Label_Prog1.Location = New System.Drawing.Point(17, 36)
        Me.Label_Prog1.Name = "Label_Prog1"
        Me.Label_Prog1.Size = New System.Drawing.Size(62, 13)
        Me.Label_Prog1.TabIndex = 2
        Me.Label_Prog1.Text = "Arrival Date"
        '
        'Label_Prog_2
        '
        Me.Label_Prog_2.AutoSize = True
        Me.Label_Prog_2.Location = New System.Drawing.Point(17, 62)
        Me.Label_Prog_2.Name = "Label_Prog_2"
        Me.Label_Prog_2.Size = New System.Drawing.Size(63, 13)
        Me.Label_Prog_2.TabIndex = 0
        Me.Label_Prog_2.Text = "Anglers Met"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStrip, Me.ExportToolStrip, Me.AboutToolStrip})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(504, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStrip
        '
        Me.FileToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStrip_Open, Me.ToolStripSeparator2, Me.FileToolStrip_Reset, Me.FileToolStrip_Exit})
        Me.FileToolStrip.Name = "FileToolStrip"
        Me.FileToolStrip.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStrip.Text = "File"
        '
        'FileToolStrip_Open
        '
        Me.FileToolStrip_Open.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStrip_Open_mgFsh0})
        Me.FileToolStrip_Open.Name = "FileToolStrip_Open"
        Me.FileToolStrip_Open.Size = New System.Drawing.Size(148, 22)
        Me.FileToolStrip_Open.Text = "Open save file"
        '
        'FileToolStrip_Open_mgFsh0
        '
        Me.FileToolStrip_Open_mgFsh0.Name = "FileToolStrip_Open_mgFsh0"
        Me.FileToolStrip_Open_mgFsh0.Size = New System.Drawing.Size(136, 22)
        Me.FileToolStrip_Open_mgFsh0.Text = "mgFsh0.dat"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(145, 6)
        '
        'FileToolStrip_Reset
        '
        Me.FileToolStrip_Reset.Name = "FileToolStrip_Reset"
        Me.FileToolStrip_Reset.Size = New System.Drawing.Size(148, 22)
        Me.FileToolStrip_Reset.Text = "Reset"
        '
        'FileToolStrip_Exit
        '
        Me.FileToolStrip_Exit.Name = "FileToolStrip_Exit"
        Me.FileToolStrip_Exit.Size = New System.Drawing.Size(148, 22)
        Me.FileToolStrip_Exit.Text = "Exit"
        '
        'ExportToolStrip
        '
        Me.ExportToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStrip_ExportmgFsh0})
        Me.ExportToolStrip.Name = "ExportToolStrip"
        Me.ExportToolStrip.Size = New System.Drawing.Size(53, 20)
        Me.ExportToolStrip.Text = "Export"
        '
        'ExportToolStrip_ExportmgFsh0
        '
        Me.ExportToolStrip_ExportmgFsh0.Name = "ExportToolStrip_ExportmgFsh0"
        Me.ExportToolStrip_ExportmgFsh0.Size = New System.Drawing.Size(173, 22)
        Me.ExportToolStrip_ExportmgFsh0.Text = "Export mgFsh0.dat"
        '
        'AboutToolStrip
        '
        Me.AboutToolStrip.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStrip_QuickStart, Me.ToolStripSeparator1, Me.AboutToolStrip_SoftwareVersion})
        Me.AboutToolStrip.Name = "AboutToolStrip"
        Me.AboutToolStrip.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStrip.Text = "About"
        '
        'AboutToolStrip_QuickStart
        '
        Me.AboutToolStrip_QuickStart.Name = "AboutToolStrip_QuickStart"
        Me.AboutToolStrip_QuickStart.Size = New System.Drawing.Size(161, 22)
        Me.AboutToolStrip_QuickStart.Text = "Quick start"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(158, 6)
        '
        'AboutToolStrip_SoftwareVersion
        '
        Me.AboutToolStrip_SoftwareVersion.Name = "AboutToolStrip_SoftwareVersion"
        Me.AboutToolStrip_SoftwareVersion.Size = New System.Drawing.Size(161, 22)
        Me.AboutToolStrip_SoftwareVersion.Text = "Software version"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 381)
        Me.Controls.Add(Me.GroupBox_Variables)
        Me.Controls.Add(Me.GroupBox_SaveInfo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Save editor for Ultimate Angler / StreetPass Fishing"
        Me.GroupBox_SaveInfo.ResumeLayout(False)
        Me.GroupBox_SaveInfo.PerformLayout()
        Me.GroupBox_Variables.ResumeLayout(False)
        Me.GroupBox_Variables.PerformLayout()
        CType(Me.NumUpDown_Prog5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUpDown_Prog3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumUpDown_Prog2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_InfoCurSave As Label
    Friend WithEvents Label_InfoCurSaveSize As Label
    Friend WithEvents Label_CurrentFile_Size As Label
    Friend WithEvents GroupBox_SaveInfo As GroupBox
    Friend WithEvents GroupBox_Variables As GroupBox
    Friend WithEvents Label_Prog_2 As Label
    Friend WithEvents Label_Prog1 As Label
    Friend WithEvents Label_Prog3 As Label
    Friend WithEvents Label_Prog6 As Label
    Friend WithEvents Label_Prog5 As Label
    Friend WithEvents Label_Prog4 As Label
    Friend WithEvents NumUpDown_Prog3 As NumericUpDown
    Friend WithEvents NumUpDown_Prog5 As NumericUpDown
    Friend WithEvents DateTimePicker_Prog1 As DateTimePicker
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStrip As ToolStripMenuItem
    Friend WithEvents FileToolStrip_Open As ToolStripMenuItem
    Friend WithEvents AboutToolStrip As ToolStripMenuItem
    Friend WithEvents AboutToolStrip_SoftwareVersion As ToolStripMenuItem
    Friend WithEvents FileToolStrip_Exit As ToolStripMenuItem
    Friend WithEvents FileToolStrip_Reset As ToolStripMenuItem
    Friend WithEvents AboutToolStrip_QuickStart As ToolStripMenuItem
    Friend WithEvents ExportToolStrip As ToolStripMenuItem
    Friend WithEvents ExportToolStrip_ExportmgFsh0 As ToolStripMenuItem
    Friend WithEvents FileToolStrip_Open_mgFsh0 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TextBox_CurrentFile_Path As TextBox
    Friend WithEvents NumUpDown_Prog2 As NumericUpDown
End Class
