using AppKit;
using Foundation;
using ManagedBass;

namespace Xamarin.Mac.Player
{
	[Register("AppDelegate")]
	public class AppDelegate : NSApplicationDelegate
	{
		public override void DidFinishLaunching(NSNotification notification)
		{
			Bass.Init();
		}

		public override void WillTerminate(NSNotification notification)
		{
			Bass.Free();
		}
	}
}

