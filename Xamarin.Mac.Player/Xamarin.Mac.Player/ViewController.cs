using System;

using AppKit;
using Foundation;
using ManagedBass;
using System.IO;

namespace Xamarin.Mac.Player
{
	public partial class ViewController : NSViewController
	{
		private bool _isPlaying = false;
		private int _stream = 0;
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Do any additional setup after loading the view.
		}

		public override NSObject RepresentedObject {
			get {
				return base.RepresentedObject;
			}
			set {
				base.RepresentedObject = value;
				// Update the view, if already loaded.
			}
		}

		partial void ButtonClicked (NSObject sender)
		{
			if(this._isPlaying) {
				//stop playing
				Bass.StreamFree(this._stream);
				Bass.Free();
				this._stream = 0;
				this.PlayButton.Title = "Play";
				this._isPlaying = false;
			} else {
				//start playing
				string audio = this.FileToPlay.StringValue;
				if(!String.IsNullOrEmpty(audio) && File.Exists(audio) && (audio.EndsWith(".mp3") || audio.EndsWith(".wav")))
				{
					Bass.Init();
					this._stream = Bass.CreateStream(this.FileToPlay.StringValue, 0, 0, BassFlags.Default);
					if(this._stream != 0) {
						Bass.ChannelPlay(this._stream);
						this.PlayButton.Title = "Stop";
						this._isPlaying = true;
					}
				}
			}
		}
	}
}
