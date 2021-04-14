using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BajerOgBillardTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        public GamePage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddPlayerPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            string GoodOrBad = await DisplayActionSheet("vælg skæve eller gode", "cancel", "destruction",
                "skæve", "gode");

            if (GoodOrBad == "skæve")
            {
                PlayerListViewModel playerListViewModel = new PlayerListViewModel();
                playerListViewModel.SelectedPlayer.Points = 10;
            }
        }
    }
}