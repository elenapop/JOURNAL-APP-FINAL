using System;
using System.Collections.Generic;
using JOURNAL.Models;
using JOURNAL.Tables;
using Xamarin.Forms;

namespace JOURNAL
{
    public partial class CityEntryPage : ContentPage
    {
        public CityEntryPage()
        {
            InitializeComponent();
        }


        //SAVE BUTTON
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var city = (City)BindingContext;
            city.Date = DateTime.UtcNow;
            await App.Database.SaveCityAsync(city);
            await Navigation.PopAsync();
        }

        //DELETE BUTTON
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var city = (City)BindingContext;
            await App.Database.DeleteCityAsync(city);
            await Navigation.PopAsync();
        }
    }
}
