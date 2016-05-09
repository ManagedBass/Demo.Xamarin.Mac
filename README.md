# ManagedBass

Simple audio player example using [ManagedBass](https://github.com/ManagedBass/ManagedBass) with Xamarin on a Mac

Bass and its Add-Ons can be downloaded at http://un4seen.com/  
ManagedBass is targeted for **Any CPU**, but bass Libraries(dll/so/dylib) are separate for x86, x64, ARM, etc.  
Download the versions you need.

> For latest info: Follow [ManagedBass Blog](https://managedbass.wordpress.com)

# How To Use

Download libbass.dylib from Un4seen, and place it in this project folder directly next to the 'Xamarin.Mac.Player.sln' file.

Open Xamarin.Mac.Player.sln using Xamarin Studio, compile and run.

When the window opens, enter the path to the audio file you wish to play, and then click Play.

While the audio is playing, click the Stop button when you wish to stop the audio.

If you encounter any exceptions while attempting to play or stop the audio, check the \bin\Debug output folder and confirm that both libbass.dylib and ManagedBass.dll exist in the output folder.




Bass and other Add-Ons are trademarks of their respective owners: **Un4Seen Bass - (c) Ian Luck**
