using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        private void GoToAbout_Clicked(object sender, EventArgs e)
        {
            var page = new About();
            NavigationPage.SetBackButtonTitle(page, "Back to Home");
            Navigation.PushAsync(page);
        }
    }
}
