# Ares
IW4X external cheat using C# .NET

# Note
This is still very early in development, there is not many features, no esp, aimbot, etc etc, so therefore there is no pre-compiled version for you to use

# Memory Reading/Writing
Ares uses [memory.dll](https://github.com/erfg12/memory.dll/)

# Adding pointers
(This is assuming you are using Cheat Engine)
* Get the address you want
* Click on the address in the Addresses panel, click the red arrow, this copys selected items to the Address List
* Right click on your Address and click Pointer scan for this address
* Set the Max level to 1 and click OK, then save the files somewhere
* Then once you get the pointer doube click it, then make sure Pointer is checked and if theres no Offset click Add Offset (You can delete the files it makes after this)
* Copy "iw4x.exe" then the pointer, then edit your pointer to base+{pointer},{offset}
