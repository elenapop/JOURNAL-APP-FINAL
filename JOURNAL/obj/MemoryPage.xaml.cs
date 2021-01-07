using System;
using System.Collections.Generic;
using JOURNAL.Models;
using JOURNAL.Views;
using Xamarin.Forms;

namespace JOURNAL
{
    public partial class MemoryPage : ContentPage
    {
        public MemoryPage()
        {
            InitializeComponent();
        }

        //LOG OUT BUTTON
        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        //SEE CITIES BUTTON
        async void OnSeeCities(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }

        //ADD MEMORY BUTTON
        async void OnMemoryAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MemoryEntryPage
            {
                BindingContext = new Memory()
            });
        }


        //AFISARE LISTA MEMORIES INREGISTRATE:
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            memoryView.ItemsSource = await App.MDatabase.GetMemoriesAsync();
        }

        //SELECTARE EL DIN MEMORYVIEW SI PERMITE MODIFICAREA ACESTUIA
        async void OnMemoryViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new MemoryEntryPage
                {
                    BindingContext = e.SelectedItem as Memory
                });
            }
        }

    }
}
