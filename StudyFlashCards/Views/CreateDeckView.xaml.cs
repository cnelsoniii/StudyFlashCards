using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StudyFlashCards.Models;
using Xamarin.Forms;

namespace StudyFlashCards.Views
{
    public partial class CreateDeckView : ContentPage
    {

        public ObservableCollection<FlashCard> FlashCards { get; set; }

        public CreateDeckView()
        {
            InitializeComponent();

            FlashCards = new ObservableCollection<FlashCard>();

            FlashCards.Add(new FlashCard { Term = "Stuff", Definition = "Things" });
            FlashCards.Add(new FlashCard { Term = "Kinda", Definition = "Lame is the thing" });
            FlashCards.Add(new FlashCard { Term = "", Definition = "Empty" });
            FlashCards.Add(new FlashCard { Term = "Shit", Definition = "" });


            BindingContext = this;

        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            FlashCards.Add(new FlashCard { Term = string.Empty, Definition = string.Empty });
        }
    }
}
