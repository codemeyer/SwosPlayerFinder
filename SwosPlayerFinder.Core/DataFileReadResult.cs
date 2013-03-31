using System.Collections.Generic;

namespace Manicomio.SwosPlayerFinder.Core
{
    public class DataFileReadResult
    {
        public DataFileReadResult()
        {
            Teams = new List<Team>();
            Players = new List<Player>();
        }

        public DataFileReadResult(List<Team> teams, List<Player> players)
        {
            Teams = teams;
            Players = players;
        }

        public List<Team> Teams { get; set; }
        public List<Player> Players { get; set; }
    }
}