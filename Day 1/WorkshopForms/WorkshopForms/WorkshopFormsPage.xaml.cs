using Xamarin.Forms;
using System.Net.Http;

namespace WorkshopForms
{
    public partial class WorkshopFormsPage : ContentPage
    {
        public WorkshopFormsPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var client = new HttpClient();

            var response = await client.GetAsync("http://www.mocky.io/v2/578527af0f0000620bc28956");

            entry.Text = await response.Content.ReadAsStringAsync();
        }
    }
}

