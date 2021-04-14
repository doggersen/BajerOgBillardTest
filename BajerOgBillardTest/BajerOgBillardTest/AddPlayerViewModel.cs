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
        }
    } 
}