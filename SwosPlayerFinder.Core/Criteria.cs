namespace Manicomio.SwosPlayerFinder.Core
{
    public class Criteria
    {
        public string Name { get; set; }

        public string TeamName { get; set; }

        //public string Nationality { get; set; }

        public int? Passing { get; set; }
        
        public int? Shooting { get; set; }

        public int? Heading { get; set; }
        
        public int? Tackling { get; set; }
        
        public int? Control { get; set; }
        
        public int? Speed { get; set; }
        
        public int? Finishing { get; set; }
    }
}