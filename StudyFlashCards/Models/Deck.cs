﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SQLite;

namespace StudyFlashCards.Models
{
    public class Deck
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int CardCount { get; set; }
        public ObservableCollection<FlashCard> FlashCards { get; set; }
    }
}
