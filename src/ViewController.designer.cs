// WARNING
//
// This file has been generated automatically by Xamarin Studio Community to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Xamarin.Mac.Player
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField FileToPlay { get; set; }

		[Outlet]
		AppKit.NSButton PlayButton { get; set; }

		[Action ("ButtonClicked:")]
		partial void ButtonClicked (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (PlayButton != null) {
				PlayButton.Dispose ();
				PlayButton = null;
			}

			if (FileToPlay != null) {
				FileToPlay.Dispose ();
				FileToPlay = null;
			}
		}
	}
}
