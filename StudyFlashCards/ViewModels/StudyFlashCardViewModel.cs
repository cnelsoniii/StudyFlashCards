using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StudyFlashCards.Models;

namespace StudyFlashCards.ViewModels
{
    public class StudyFlashCardViewModel
    {
        public List<FlashCard> FlashCards { get; set; }

        public StudyFlashCardViewModel(Deck deck)
        {
            FlashCards = deck.FlashCards;
        }
    }
}
