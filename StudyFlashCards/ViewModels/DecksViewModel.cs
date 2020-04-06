using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using StudyFlashCards.Models;
using StudyFlashCards.Views;
using Xamarin.Forms;

namespace StudyFlashCards.ViewModels
{
    public class DecksViewModel
    {
        public ICommand CreateNewDeckCommand => new Command(CreateNewDeck);

        public List<Deck> Decks { get; set; }

        public DecksViewModel()
        {
            Decks = new List<Deck>();
       
            Deck deck1 = new Deck();
            deck1.Title = "Testing";
            List<FlashCard> flashcards1 = new List<FlashCard>();
            flashcards1 = new List<FlashCard>();
            flashcards1.Add(new FlashCard { Term = "Studying" });
            flashcards1.Add(new FlashCard { Term = "Hard" });
            deck1.FlashCards = flashcards1;
            deck1.CardCount = deck1.FlashCards.Count;

            Deck deck2 = new Deck();
            deck2.Title = "Testing";
            List<FlashCard> flashcards2 = new List<FlashCard>();
            flashcards2 = new List<FlashCard>();
            flashcards2.Add(new FlashCard { Term = "Cornelius" });
            flashcards2.Add(new FlashCard { Term = "Nelson" });
            flashcards2.Add(new FlashCard { Term = "III" });
            deck2.FlashCards = flashcards2;
            deck2.CardCount = deck2.FlashCards.Count;


            Decks.Add(deck1);
            Decks.Add(deck2);
        }

        public void CreateNewDeck()
        {
            Application.Current.MainPage.Navigation.PushAsync( new CreateDeckView
            {
                BindingContext = new CreateDeckViewModel()
            });
        }
    }
}
