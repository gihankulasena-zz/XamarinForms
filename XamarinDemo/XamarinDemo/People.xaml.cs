using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo.Data;
using XamarinDemo.Model;
using XamarinForms.Interfaces;

namespace XamarinDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class People : ContentPage
    {
        PersonDb person = new PersonDb();
        public People()
        {
            InitializeComponent();
            this.Title = "Person List";

            var toolbarItem = new ToolbarItem
            {
                Text = "+ Add New"
            };

            toolbarItem.Clicked += (sender, e) =>
             {
                 Navigation.PushAsync(new PersonForm() { BindingContext = new Person() });
             };

            ToolbarItems.Add(toolbarItem);
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //PersonDb person = new PersonDb();
            PeopleListView.ItemsSource = person.GetPeople();
        }

        private void PeopleListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                Navigation.PushAsync(new PersonForm()
                {
                    BindingContext = e.SelectedItem as Person
                });
            }
        }
    }
}
