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
    public partial class MasterLayout : MasterDetailPage
    {
        public MasterLayout()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Home());
            IsPresented = false; //always show master page
        }

        private void Home_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Home());
            IsPresented = false;
        }

        private void About_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new About());
            IsPresented = false;
        }

        private void Demo_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new GreetPage());
            IsPresented = false;
        }

        private void CRUD_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new People());
            IsPresented = false;
        }
    }
}
