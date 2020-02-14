# 3 Test cases for Remote WinAppDriver

In order to run the testcases you need the following prerequisites:

* Windows 10
* VIsual Studio or any IDE that could run .NET Core
* SDK installed [Click here to get it](https://developer.microsoft.com/en-us/windows/downloads/windows-10-sdk/)
* The WinAppDriver [https://github.com/Microsoft/WinAppDriver/releases](https://developer.microsoft.com/en-us/windows/downloads/windows-10-sdk/)
* Check that you have the correct applicacion installed. Go to the search box and type Remote Control. There should be an application with that exact name, if not you could get it from the Microsoft Store. *(Don't confuse the target app with another one called Remote Control Connection)*


# Steps
## 1. The solution
- clone the repo. 
- Open the sln file (double click on it)
- Clean and build the solution


## 2. Start the server (WinAppDriver)

- Open up a new CMD.
- Go to the installation directory of the WinAppDriver.exe and from the Command line 
    *Usually (C:\Program Files (x86)\Windows Application Driver)*
- Type *WinAppDriver.exe*
- Make sure the command executes the file.


## 3. Run the tests

- We are all set, all what we need is to go to the solution explorer and right click on the TestSuite file and then click on "run tests".


## Disclamer

- The tests could be run from the command line but this is out of the scope of this repo.

