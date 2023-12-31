# Ryujinx-Shortcut
* The purpose of this project is to create windows executables to quickly launch switch games utilizing the Ryujinx emulator.

## File Tree
* Here is what your directory should look like

```
{
    "_Ryujinx":{
        "ryujinx.exe"
    }
    "Game":{
        "Game.nsp"
    }
}
```
* Your ryujinx folder MUST be named _ryujinx (case sensitivity will vary depending on operating system)


## How to use:
1.
```CMD
git clone https://github.com/Adam-S-Amir/Ryujinx-Shortcut.git
cd Ryujinx-Shortcut
start .
```

2. Open in Visual Studio
3. Open "Program.cs"
    * On line 12, replace "Game" with your Switch Game folder name
    * Replace "GameID" with the Switch ROM name
```
//Example:
string nspFilePath = Path.Combine("..", "Mario Kart 8 Deluxe", "0100152000022000.nsp");
```
* (optional) Change ryujinx.ico with custom .ico
4. Build the project

5.
```CMD
cd Ryujinx-Shortcut
cd bin
cd Debug
start .
```

6. Copy ryujinx.exe to the root of your switch game folder
    * (optional) Change the file name "ryujinx.exe" you just built to something else      

7. Your directory should look like afterwards
```
{
    "_Ryujinx":{
        "ryujinx.exe"
    }
    "Game":{
        "Game.nsp"
        "Game.exe"
    }
}
```
8. Enjoy!

# TODO
- [ ] Linux Support
- [ ] MacOS Support
- [ ] Yuzu Support
