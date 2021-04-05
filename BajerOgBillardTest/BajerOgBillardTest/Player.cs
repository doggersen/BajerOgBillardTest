using System;
using System.Collections.Generic;
using System.Text;

namespace BajerOgBillardTest
{
    public class Player : BaseViewModel
    {
        //public string Name { get; set; }
        //public int Points { get; set; }


        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        private int _points;
        public int Points
        {
            get { return _points; }
            set
            {
                _points = value;
                OnPropertyChanged();
            }
        }

        //this is a constructor, its initiated when u make an object. 
        public Player(string name, int points = 60)
        {
            Name = name;
            Points = points;

        }

        


    }
}
