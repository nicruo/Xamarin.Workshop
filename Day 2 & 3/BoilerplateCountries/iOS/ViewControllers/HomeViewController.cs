using Boilerplate.Domain;
using Boilerplate.ViewModels;
using Foundation;
using GalaSoft.MvvmLight.Helpers;
using UIKit;

namespace Boilerplate.iOS.ViewControllers
{
    public partial class HomeViewController : UIViewController
    {
        private ObservableTableViewController<Country> _tableViewController;
        HomeViewModel ViewModel => Application.Locator.HomeViewModel;

        public override async void ViewDidLoad()
        {
            base.ViewDidLoad();
            CreateViews();
            AddConstraints();

            await ViewModel.InitAsync();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            _tableViewController = ViewModel.Countries.GetController(CreateCountryCell, BindCellDelegate);
            _tableViewController.TableView = TableView;
        }

        private void BindCellDelegate(UITableViewCell cell, Country country, NSIndexPath path)
        {
            cell.TextLabel.Text = country.Name;
        }

        private UITableViewCell CreateCountryCell(NSString cellIdentifier)
        {
            return new UITableViewCell(UITableViewCellStyle.Default, "USA");
        }
    }
}