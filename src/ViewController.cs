using System;
using System.IO;
using AppKit;
using Foundation;
using ManagedBass;

namespace Xamarin.Mac.Player
{
	public partial class ViewController : NSViewController
	{
		bool _isPlaying;
		int _stream;
		
		public ViewController(IntPtr handle) : base(handle) { }

		partial void ButtonClicked(NSObject sender)
		{
			if (_isPlaying)
			{
				//stop playing
				Bass.StreamFree(_stream);
				_stream = 0;
				PlayButton.Title = "Play";
				_isPlaying = false;
			}
			else
			{
				//start playing
				var audio = FileToPlay.StringValue;
				
				if (!string.IsNullOrEmpty(audio) && File.Exists(audio) && (audio.EndsWith(".mp3") || audio.EndsWith(".wav")))
				{					
					_stream = Bass.CreateStream(FileToPlay.StringValue);
					
					if (_stream != 0)
					{
						Bass.ChannelPlay(_stream);
						PlayButton.Title = "Stop";
						_isPlaying = true;
					}
				}
			}
		}
	}
}
