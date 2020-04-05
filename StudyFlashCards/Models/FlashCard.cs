using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SQLite;

namespace StudyFlashCards.Models
{
    public class FlashCard
    {
        public string Term { get; set; }
        public string Definition { get; set; }
    }
}
