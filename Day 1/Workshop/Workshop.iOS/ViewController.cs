using System;

using UIKit;

namespace Workshop.iOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            messageButton.TouchUpInside += MessageButton_TouchUpInside;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        void MessageButton_TouchUpInside(object sender, EventArgs e)
        {
            messageLabel.Text = "Goodbye world";
        }
    }
}

