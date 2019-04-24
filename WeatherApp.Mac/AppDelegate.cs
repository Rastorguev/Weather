using AppKit;
using CoreGraphics;
using Foundation;
using WeatherApp;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

[Register("AppDelegate")]
public class AppDelegate : FormsApplicationDelegate
{
	public AppDelegate()
	{
		var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;

		var rect = new CGRect(200, 1000, 1024, 768);
		MainWindow = new NSWindow(rect, style, NSBackingStore.Buffered, false)
		{
			Title = "Xamarin.Forms on Mac!", TitleVisibility = NSWindowTitleVisibility.Hidden
		};
	}

	public override NSWindow MainWindow { get; }

	public override void DidFinishLaunching(NSNotification notification)
	{
		Forms.Init();
		LoadApplication(new App());
		base.DidFinishLaunching(notification);
	}
}