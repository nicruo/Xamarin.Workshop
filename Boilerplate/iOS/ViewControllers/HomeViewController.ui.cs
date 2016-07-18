using System;
using Cirrious.FluentLayouts.Touch;
using UIKit;

namespace Boilerplate.iOS.ViewControllers
{
    public partial class HomeViewController
    {
        public UILabel WelcomeLabel
        {
            get;
            set;
        }

        private void CreateViews()
        {
            WelcomeLabel = new UILabel();

            View.Add(WelcomeLabel);
        }

        private void AddConstraints()
        {
            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            View.AddConstraints(
                WelcomeLabel.AtTopOf(View, 20),
                WelcomeLabel.AtLeftOf(View, 20),
                WelcomeLabel.AtRightOf(View, 20)
            );
        }
    }
}