using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BajerOgBillardTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new BajerOgBillardTest.GamePage());
         //   MainPage = new BajerOgBillardTest.AddPlayerPage();
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
