using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo.Data;
using XamarinDemo.Model;

namespace XamarinDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonForm : ContentPage
    {
        public PersonForm()
        {
            InitializeComponent();
        }

        async void Save_Clicked(object sender, System.EventArgs e)
        {
            var personItem = (Person)BindingContext;
            PersonDb person = new PersonDb();
            person.SavePerson(personItem);
            await Navigation.PopAsync();
        }

        async void Cancel_Clicked(object sender, System.EventArgs e)
        {               
            await Navigation.PopAsync();
        }
    }
}
