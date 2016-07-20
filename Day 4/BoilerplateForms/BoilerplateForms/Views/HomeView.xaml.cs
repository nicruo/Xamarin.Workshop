using System;
using System.Collections.Generic;
using BoilerplateForms.ViewModels;
using Xamarin.Forms;

namespace BoilerplateForms.Views
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "");
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await (BindingContext as HomeViewModel).InitAsync();
        }
    }
}

