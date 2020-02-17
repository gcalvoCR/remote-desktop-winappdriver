# Automation of Windows apps. 3 Test cases using WinAppDriver

In order to run the testcases you need the following prerequisites:

* Windows 10.
* Visual Studio or any IDE that could run .NET Core.
* SDK installed [click here to get it](https://developer.microsoft.com/en-us/windows/downloads/windows-10-sdk/).
* The WinAppDriver, [click here to get it](https://github.com/Microsoft/WinAppDriver/releases).
* Check that you have the correct applicacion installed. Go to the search box and type **Remote Control**. There should be an application with that exact name, if not you could get it from the Microsoft Store. *(Don't confuse the target app with another one called "Remote Control Connection")*


# Steps
## 1. The solution
- Clone the repo, [here it is](https://github.com/gcalvoCR/remote-desktop-winappdriver).
- Open the solution in Visual Studio, (double click on the .sln file).
- Right click on the solution explore, Clean and build the solution.


## 2. Start the server (WinAppDriver)

- Open up a new CMD.
- Navigate to the installation directory of the WinAppDriver.exe,  
    *usually (C:\Program Files (x86)\Windows Application Driver)* 
- Type *WinAppDriver.exe* on the CMD.
- Make sure the server starts, The CMD should say ` **Windows Application Driver listening for requests at: http://127.0.0.1:4723/**. `


## 3. Run the tests

- We are all set, all what we need is to go to the solution explorer in Visual Studio, right click on the Solution and click on "run tests" option.

***

## Disclamer

- The tests should be run from the command line (CMD), but this is out of the scope of this repo.
- This repo doesn't take in count any management tool, in order to make it really useful, you should integrate it to a reporter tool.

Have any questions? Feel free to reach out to me!


### by Gabriel Calvo Vargas

