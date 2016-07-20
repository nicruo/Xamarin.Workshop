using System;
using Cirrious.FluentLayouts.Touch;
using UIKit;

namespace Boilerplate.iOS.ViewControllers
{
    public partial class HomeViewController
    {
        public UITableView TableView
        {
            get;
            set;
        }

        private void CreateViews()
        {
            TableView = new UITableView();

            View.Add(TableView);
        }

        private void AddConstraints()
        {
            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            View.AddConstraints(
                TableView.AtTopOf(View, 10),
                TableView.AtLeftOf(View),
                TableView.AtRightOf(View),
                TableView.AtBottomOf(View)
            );
        }
    }
}