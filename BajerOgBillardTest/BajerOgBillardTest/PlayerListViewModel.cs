using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BajerOgBillardTest
{
    class PlayerListViewModel : BaseViewModel
    {

        public ICommand AddPlayerCommand => new Command(AddPlayer);
        public ICommand DeletePlayerCommand => new Command(DeletePlayer);
        public ICommand UpdatePlayerCommand => new Command(UpdatePlayer);

        //public ObservableCollection<Player> Players { get; set; }
        private ObservableCollection<Player> _players { get; set; }

        public ObservableCollection<Player> Players 
        {
            get { return _players; }
            set
            {
                _players = value;
                OnPropertyChanged();
            }
        }


        //since we deal with the Player objects, we need this temporary variable to store user-input. 
        //so later, when we need to add player objects to the list, we can add "InputName" (that contains the user input)

        //public string InputName { get; set; }

        private string _inputName;
        public string InputName
        {
            get { return _inputName; }
            set
            {
                _inputName = value;
                OnPropertyChanged();
            }
        }


        public Player SelectedPlayer { get; set; }



        public PlayerListViewModel()
        {
            Players = new ObservableCollection<Player>();

            //The player class consists of Name and Points, i only write name here, because the points have a default value of 60
            Players.Add(new Player("Jimmy"));
            Players.Add(new Player("Cherryl"));
            Players.Add(new Player("Martin"));
            
        }

        public void AddPlayer()
        {
            //it wants a Player object, so we use the property from above
           Players.Add(new Player(InputName));
           
        }

        public void DeletePlayer()
        {
            Players.Remove(SelectedPlayer);
        }

        public void UpdatePlayer()
        {
            
            
            int newIndex = Players.IndexOf(SelectedPlayer);
            Players.Remove(SelectedPlayer);

            //we make a temporary variable that points to the new Player object, so we can use it..........
            Player test = new Player(InputName);
            Players.Add(test);
            //.............................here!
            int oldIndex = Players.IndexOf(test);

            Players.Move(oldIndex, newIndex);

        }


    }
}
