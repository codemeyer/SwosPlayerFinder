using System.Collections.Generic;

namespace Manicomio.SwosPlayerFinder.Core
{
    public class Team
    {
        public Team()
        {
            Players = new List<Player>();
        }

        public string Name { get; set; }

        public string Nationality { get; set; }

        public List<Player> Players { get; set; }
    }
}