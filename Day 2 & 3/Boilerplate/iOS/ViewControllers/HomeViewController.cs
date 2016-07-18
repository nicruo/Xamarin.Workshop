using Boilerplate.ViewModels;
using GalaSoft.MvvmLight.Helpers;
using UIKit;

namespace Boilerplate.iOS.ViewControllers
{
    public partial class HomeViewController : UIViewController
    {
        HomeViewModel ViewModel => Application.Locator.HomeViewModel;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            CreateViews();
            AddConstraints();

            this.SetBinding(() => ViewModel.WelcomeMessage, () => WelcomeLabel.Text);
        }
    }
}