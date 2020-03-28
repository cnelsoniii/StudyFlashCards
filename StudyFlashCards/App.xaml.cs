using System;
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

            MainPage = new NavigationPage(new DecksView());
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
