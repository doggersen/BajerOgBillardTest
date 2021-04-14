using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace BajerOgBillardTest
{
     class AddPlayerViewModel
    {
        public Player Player { get; set; }

        public AddPlayerViewModel()
        {
            Player = new Player();
            //linjen tilføjet af mig, uden den, sætter den scoren til 0 på spilleren man lige har tilføjet. 
            Player.Points = 60;
        }
    } 
}