using System;
using System.Collections.Generic;
using JOURNAL.Models;
using Xamarin.Forms;

namespace JOURNAL
{
    public partial class MemoryEntryPage : ContentPage
    {
        public MemoryEntryPage()
        {
            InitializeComponent();
        }

        //SAVE BUTTON
        async void OnSaveMemoryButtonClicked(object sender, EventArgs e)
        {
            var memory = (Memory)BindingContext;
            memory.Date = DateTime.UtcNow;
            await App.MDatabase.SaveMemoryAsync(memory);
            await Navigation.PopAsync();
        }

        //DELETE BUTTON
        async void OnDeleteMEmoryButtonClicked(object sender, EventArgs e)
        {
            var memory = (Memory)BindingContext;
            await App.MDatabase.DeleteMemoryAsync(memory);
            await Navigation.PopAsync();
        }
    }
}
