using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BajerOgBillardTest
{
    class PlayerListViewModel
    {
        public ObservableCollection<Player> Players { get; set; }


        public PlayerListViewModel()
        {
            Players = new ObservableCollection<Player>();

            Players.Add(new Player("Jimmy", 60));
            Players.Add(new Player("Cherryl", 60));
            Players.Add(new Player("Martin", 60));

        }


    }
}
