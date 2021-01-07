using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using JOURNAL.Views;
using JOURNAL.Tables;
using JOURNAL;
using JOURNAL.Models;

namespace JOURNAL
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        //LOG OUT BUTTON
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        //SEE MEMORIES BUTTON
        async void OnSeeMemories(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MemoryPage());
        }


        //ADD CITY BUTTON
        async void OnCityAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CityEntryPage
            {
                BindingContext = new City()
            });
        }


        //EVENIMENT DE AFISARE LISTA ORASE
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            listView.ItemsSource = await App.Database.GetCitiesAsync();
        }

        //SELECTARE EL DIN LISTAVIEW SI PERMITE MODIFICAREA ACESTUIA
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new CityEntryPage
                {
                    BindingContext = e.SelectedItem as City
                });
            }
        }

        
    }
}

