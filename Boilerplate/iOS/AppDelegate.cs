using Boilerplate.iOS.ViewControllers;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Boilerplate.iOS
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
 
        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Window = new UIWindow(UIScreen.MainScreen.Bounds);
            Window.BackgroundColor = UIColor.White;
            Window.RootViewController = new HomeViewController();
            Window.MakeKeyAndVisible();
            return true;
        }
    }
}