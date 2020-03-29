using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Input;
using StudyFlashCards.Models;
using Xamarin.Forms;

namespace StudyFlashCards.ViewModels
{
    public class CreateDeckViewModel : INotifyPropertyChanged
    {
        public ICommand AddFlashCardCommand => new Command(AddFlashCard);
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

        void OnPropertyChanged(string title)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(title));
        }
    }
}
