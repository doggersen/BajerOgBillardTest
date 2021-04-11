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
    }
}