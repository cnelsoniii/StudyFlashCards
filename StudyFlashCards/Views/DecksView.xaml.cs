using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StudyFlashCards.Models;
using StudyFlashCards.ViewModels;
using Xamarin.Forms;

namespace StudyFlashCards.Views
{
    public partial class DecksView : ContentPage
    {
        public DecksView()
        {
            InitializeComponent();
        }

        void ListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            //Deck deck = new Deck();
            //List<FlashCard> flashcards = new List<FlashCard>();

            //flashcards = new List<FlashCard>();
            //flashcards.Add(new FlashCard { Term = "Studying" });
            //flashcards.Add(new FlashCard { Term = "Hard" });

            //deck.FlashCards = flashcards;

            Deck tappedDeck = (Deck)((ListView)sender).SelectedItem;

            Application.Current.MainPage.Navigation.PushAsync(new StudyFlashCardsView
            {
                BindingContext = new StudyFlashCardViewModel(tappedDeck)
            });
        }
    }
}
