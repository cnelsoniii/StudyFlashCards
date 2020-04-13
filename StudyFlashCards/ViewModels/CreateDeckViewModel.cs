using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Windows.Input;
using StudyFlashCards.Models;
using Xamarin.Forms;

namespace StudyFlashCards.ViewModels
{
    public class CreateDeckViewModel : INotifyPropertyChanged
    {
        public ICommand AddFlashCardCommand => new Command(AddFlashCard);
        public ICommand SaveDeckCommand => new Command(SaveDeck);
        public event PropertyChangedEventHandler PropertyChanged;

        string title = string.Empty;
        public string Title
        {
            get => title;
            set
            {
                if (title == value)
                    return;
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        Deck deck = new Deck();
        public Deck Deck
        {
            get => deck;
            set
            {
                if (deck == value)
                    return;
                deck = value;
                OnPropertyChanged(nameof(Deck));
            }
        }

        public ObservableCollection<FlashCard> FlashCards { get; set; }

        public CreateDeckViewModel()
        {
            FlashCards = new ObservableCollection<FlashCard>();
            AddFlashCard();
        }

        public void AddFlashCard()
        {
            FlashCards.Add(new FlashCard { Term = string.Empty, Definition = string.Empty });
        }

        public void SaveDeck()
        {
            if(deck != null)
            {
                deck.Title = this.title;
                deck.CardCount = this.FlashCards.Count;
                deck.FlashCards = this.FlashCards.ToList();
            }
        }

        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
