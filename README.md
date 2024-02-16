# saveeditor_ua
Tool to edit save files from Ultimate Angler / StreetPass Fishing

![screenshot1](https://github.com/Zapo3DS/saveeditor_ua/assets/159708642/fa86ca25-feab-45b0-a672-d267780fc292)


## What this tool can currently edit
Currently the save editor is just a Proof of Concept, it can edit some of the data in the Progress Report:
- Arrival Date
- Anglers Met
- Trips Taken
- Treasure Chests Found

(I could not find the offsets for 'Group Catches Made' and 'Rod Types Collected', these are most likely calculated during the game's execution)

# How to use
1. Dump the ExtData from the StreetPass Mii Plaza folder using any save tool, such as JKSV
2. Locate the mgFsh0.dat save file
3. Open it with the save editor
4. Edit the values to your heart's content
5. Export a new copy of the save file as mgFsh0.dat
6. Restore the modified copy of the save file

# Disclaimer
Although I have carefully inspected the code and tested edited save files to ensure the data is correctly written, data loss is still a possibility. Please keep a backup of the original save file, you are responsible for the loss of your own data.
