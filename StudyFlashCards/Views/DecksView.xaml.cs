using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StudyFlashCards.Models;
using Xamarin.Forms;

namespace StudyFlashCards.Views
{
    public partial class DecksView : ContentPage
    {
        public ObservableCollection<Deck> Decks { get; set; }

        public DecksView()
        {
            InitializeComponent();

            Decks = new ObservableCollection<Deck>();

            Decks.Add(new Deck { Name = "Deck 1", CardCount = 69 });
            Decks.Add(new Deck { Name = "Deck 2", CardCount = 21 });
            Decks.Add(new Deck { Name = "Deck 3", CardCount = 13 });
            Decks.Add(new Deck { Name = "Deck 4", CardCount = 100 });

            BindingContext = this;
        }

        async void ListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            await Navigation.PushAsync(new CreateDeckView());
        }
    }
}
