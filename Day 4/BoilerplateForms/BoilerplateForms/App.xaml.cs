using BoilerplateForms.Helpers;
using BoilerplateForms.ViewModels;
using BoilerplateForms.Views;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Xamarin.Forms;

namespace BoilerplateForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var nav = new NavigationService();
            nav.Configure(ViewModelLocator.HomeViewKey, typeof(HomeView));
            nav.Configure(ViewModelLocator.AboutViewKey, typeof(AboutView));


            SimpleIoc.Default.Register<INavigationService>(() => nav);

            var navPage = new NavigationPage(new HomeView());

            nav.Initialize(navPage);

            MainPage = navPage;
        }
    }
}

