using System;
using StudyFlashCards.Data;
using StudyFlashCards.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace StudyFlashCards
{
    public partial class App : Application
    {
        static DecksDatabase database;

        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new DecksView());

            MainPage = nav;

        }

        public static DecksDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new DecksDatabase();
                }
                return database;
            }
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
