namespace Manicomio.SwosPlayerFinder.Core
{
    public class Player
    {
        public Player()
        {
            Skills = new Skills();
            Team = new Team();
        }

        public string Nationality { get; set; }
        
        public string Name { get; set; }
        
        public Skills Skills { get; set; }
        
        public int Value { get; set; }
        
        public Position Position { get; set; }

        public Team Team { get; set; }
    }
}