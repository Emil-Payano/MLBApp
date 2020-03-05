using MLBTeamsApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MLBTeamsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TeamsPage();
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
