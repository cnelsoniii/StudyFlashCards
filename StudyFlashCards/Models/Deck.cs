using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace StudyFlashCards.Models
{
    public class Deck
    {
        public string Name { get; set; }
        public int CardCount { get; set; }
        public ObservableCollection<FlashCard> FlashCards { get; set; }
    }
}
