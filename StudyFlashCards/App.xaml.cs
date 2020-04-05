using System;
using System.Collections.Generic;
using System.IO;
using StudyFlashCards.Data;
using StudyFlashCards.Models;
using StudyFlashCards.ViewModels;
using StudyFlashCards.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace StudyFlashCards
{
    public partial class App : Application
    {
        static DecksDatabase database;

        public static DecksDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new DecksDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Decks.db3"));
                }
                return database;
            }
        }
        public List<FlashCard> FlashCards { get; set; }

        public App()
        {
            InitializeComponent();

            Deck deck = new Deck();

            FlashCards = new List<FlashCard>();
            FlashCards.Add(new FlashCard { Term = "Studying" });
            FlashCards.Add(new FlashCard { Term = "Hard" });

            deck.FlashCards = FlashCards;

            //var nav = new NavigationPage(new DecksView
            //{
            //    BindingContext = new DecksViewModel()
            //});

            //MainPage = nav;

            //Temporary in order to test StudyFlashCardView
            var nav = new NavigationPage(new StudyFlashCardsView
            {
                BindingContext = new StudyFlashCardViewModel(deck)
            });

            MainPage = nav;

            //MainPage = new StudyFlashCardsView();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
