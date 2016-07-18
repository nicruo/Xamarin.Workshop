using System;
using Android.App;
using Boilerplate.ViewModels;
using GalaSoft.MvvmLight.Helpers;

namespace Boilerplate.Droid.Activities
{
    [Activity(MainLauncher = true)]
    public partial class HomeActivity: Activity
    {
        HomeViewModel ViewModel = App.Locator.HomeViewModel;

        protected override void OnCreate(Android.OS.Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Home);

            this.SetBinding(() => ViewModel.WelcomeMessage, () => WelcomeTextView.Text );
        }
    }
}