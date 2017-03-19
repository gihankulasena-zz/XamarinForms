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
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
            slider.Value = 0;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Hello", "OK");
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            //labelDefault.Text = String.Format("Value is {0:F2}", e.NewValue);
        }
    }
}
