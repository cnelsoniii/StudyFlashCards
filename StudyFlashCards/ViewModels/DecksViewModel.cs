using System;
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

        public ObservableCollection<Deck> Decks { get; set; }

        public DecksViewModel()
        {
            
        }

        public async void OnAppearing()
        {
            Decks = new ObservableCollection<Deck>(await App.Database.GetDecksAsync());
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
