using System;
using Android.App;
using Android.Views;
using Android.Widget;
using Boilerplate.Domain;
using Boilerplate.ViewModels;
using GalaSoft.MvvmLight.Helpers;

namespace Boilerplate.Droid.Activities
{
    [Activity(MainLauncher = true)]
    public partial class HomeActivity: Activity
    {
        HomeViewModel ViewModel = App.Locator.HomeViewModel;

        protected override async void OnCreate(Android.OS.Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Home);

            await ViewModel.InitAsync();

            ListView.Adapter = ViewModel.Countries.GetAdapter(GetCountryView);
        }

        private View GetCountryView(int position, Country country, View convertView)
        {
            View view = convertView ?? LayoutInflater.Inflate(Resource.Layout.RowCountry, null);

            var name = view.FindViewById<TextView>(Resource.Id.Name);

            name.Text = country.Name;

            return view;
        }
    }
}