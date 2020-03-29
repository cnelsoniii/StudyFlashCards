using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using StudyFlashCards.Models;
using Xamarin.Forms;

namespace StudyFlashCards.Views
{
    public partial class CreateDeckView : ContentPage
    {
        public CreateDeckView()
        {
            InitializeComponent();
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            //FlashCards.Add(new FlashCard { Term = string.Empty, Definition = string.Empty });
        }
    }
}
