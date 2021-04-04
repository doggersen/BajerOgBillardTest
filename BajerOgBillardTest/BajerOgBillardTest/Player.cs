using System;
using System.Collections.Generic;
using System.Text;

namespace BajerOgBillardTest
{
    public class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }
        
        public Player(string name, int points = 60)
        {
            Name = name;
            Points = points;

        }


        //private double _name;
        //public double Name
        //{
        //    get { return _name; }
        //    set
        //    {
        //        _name = value;
        //        OnPropertyChanged();
        //    }
        //}

        //private double _points;
        //public double Points
        //{
        //    get { return _points; }
        //    set
        //    {
        //        _points = value;
        //        OnPropertyChanged();
        //    }
        //}



    }
}
