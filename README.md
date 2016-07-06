# Xamarin.Mac.AudioPlayer
Simple audio player example using ManagedBass with Xamarin on a Mac

Contributed by: [Brian Pieslak](github.com/bpieslak)

# How To Use
1. Download `libbass.dylib` from Un4seen, and place it in the `src` folder.
2. Open `Xamarin.Mac.Player.sln` using Xamarin Studio, compile and run.
3. When the window opens, enter the path to the audio file you wish to play, and then click Play.
4. While the audio is playing, click the Stop button when you wish to stop the audio.
5. If you encounter any exceptions while attempting to play or stop the audio, check the `\bin\Debug` output folder and confirm that both `libbass.dylib` and `ManagedBass.PInvoke.dll` exist in the output folder.