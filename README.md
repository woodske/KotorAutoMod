# KotorAutoMod

There are a lot of KotoR mods so many people have come up with mod builds that have been tested and validated to work. This application aims to make modding KotoR a little bit easier by automating the install process for some of these builds. The builds supported at the moment are listed below:

1. StellarExile's KotoR 1 build: https://www.nexusmods.com/kotor/mods/1463
2. Snigaroo's KotoR 1 build: https://reddit.com/r/kotor/wiki/kotormodbuildfull

## Prerequisites

.NET 6.0 Runtime x86 for Windows desktop apps is required to run this program:    

Microsoft page:    
https://dotnet.microsoft.com/en-us/download/dotnet/6.0/runtime?cid=getdotnetcore

Direct Install:    
https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-desktop-6.0.8-windows-x86-installer

## How to use

This application is intended to be used on a fresh installation.

There are some configuration selections to the bottom left of the application. You will need to... 
* Select the mod build you want to use
* Select your swkotor installation folder 
* Select the folder with all of your *compressed* mods (the files needed can be found by clicking a mod in the available mods or missing mods sections)
* Checkbox for doing a widescreen setup (this is highly recommended)
* Checkbox for automatically applying mods. This uses the TSLPatcherCLI to run TSLPatcher in the background as well as makes default choices for some mods, such as eye color. Otherwise, you will need to run TSLPatcher by hand and be prompted for choices during some mod installations.
* Some mods require your aspect ratio and screen resolution so select those if available

Once all of the configuration options are set, the 'Apply Mods' button will clickable. Click 'Apply Mods' and follow the instructions in the instructions box.

## TSLPatcherCLI

The source code for TSLPatcher was recently released. I stripped out the GUI and added CLI options to set the install path, mod path, and mod option in order to run the TSLPatcher in the background. Using TSLPatcherCLI creates a TSLPatcherInstallSummary.txt file in your swkotor folder. This gives a summary of errors/warning that you can further investigate by locating the installlog.rtf file in each extracted mod folder that uses TSLPatcher.

https://github.com/woodske/TSLPatcher

## Screenshot

![image](https://user-images.githubusercontent.com/20936822/184259761-df84fae6-3aa0-4a7e-9652-3f125a5ea705.png)

