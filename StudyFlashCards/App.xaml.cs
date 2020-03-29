using System;
using StudyFlashCards.Data;
using StudyFlashCards.ViewModels;
using StudyFlashCards.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace StudyFlashCards
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new DecksView
            {
                BindingContext = new DecksViewModel()
            });

            MainPage = nav;

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
