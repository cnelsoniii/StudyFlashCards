using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace StudyFlashCards.Models
{
    public class Deck
    {
        public string Title { get; set; }
        public int CardCount { get; set; }
        public List<FlashCard> FlashCards { get; set; }
    }
}
