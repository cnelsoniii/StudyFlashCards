using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StudyFlashCards.Models;
using Xamarin.Forms;

namespace StudyFlashCards.Views
{
    public partial class DecksView : ContentPage
    {
        public DecksView()
        {
            InitializeComponent();
        }

        async void ListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new CreateDeckView());
        }

        async void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CreateDeckView
            {
                BindingContext = new Deck()
            });
        }
    }
}
