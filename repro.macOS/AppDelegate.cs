﻿using AppKit;
using Foundation;
using repro;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;
// also add a using for the Xamarin.Forms project, if the namespace is different to this file
[Register("AppDelegate")]
public class AppDelegate : FormsApplicationDelegate
{
    NSWindow window;
    public AppDelegate()
    {
        var style = NSWindowStyle.Titled |
            NSWindowStyle.Closable |
            NSWindowStyle.Miniaturizable |
            NSWindowStyle.Resizable |
            NSWindowStyle.FullSizeContentView |
            NSWindowStyle.UnifiedTitleAndToolbar;

        var rect = new CoreGraphics.CGRect(200, 1000, 1024, 768);
        window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
        window.Title = "Xamarin.Forms on Mac!"; // choose your own Title here
        window.TitleVisibility = NSWindowTitleVisibility.Hidden;
        window.BackgroundColor = NSColor.Blue;
        window.TitlebarAppearsTransparent = true;
        window.MovableByWindowBackground = true;
        window.DidResize += Window_DidResize;
    }

    private void Window_DidResize(object sender, System.EventArgs e)
    {

    }

    public override NSWindow MainWindow
    {
        get { return window; }
    }

    public override void DidFinishLaunching(NSNotification notification)
    {
        Forms.Init();
        LoadApplication(new App());
        base.DidFinishLaunching(notification);
    }
}