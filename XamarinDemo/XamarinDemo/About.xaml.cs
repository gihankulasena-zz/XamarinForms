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
    public partial class About : ContentPage
    {
        public About()
        {
            InitializeComponent();
        }

        private void GoToDemo_Clicked(object sender, EventArgs e)
        {
            var page = new GreetPage();
            NavigationPage.SetBackButtonTitle(page, "Back to About");
            Navigation.PushAsync(page);
        }
    }
}
