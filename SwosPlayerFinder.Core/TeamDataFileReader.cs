using System.Collections.Generic;
using System.IO;

namespace Manicomio.SwosPlayerFinder.Core
{
    public class TeamDataFileReader : ITeamDataFileReader
    {
        private BinaryReader _binaryReader;

        public DataFileReadResult Read(string dataPath)
        {
            _binaryReader = new BinaryReader(new FileStream(dataPath, FileMode.Open));

            _binaryReader.ReadByte();
            byte teamCount = _binaryReader.ReadByte();

            var teams = new List<Team>();
            var players = new List<Player>();

            for (int i = 1; i < teamCount; i++)
            {
                Team team = ReadTeam();
                teams.Add(team);

                for (int playerIndex = 1; playerIndex <= 16; playerIndex++)
                {
                    Player player = ReadPlayer();
                    players.Add(player);

                    AssociatePlayerAndTeam(player, team);
                }
            }

            _binaryReader.Close();
            _binaryReader.Dispose();

            return new DataFileReadResult(teams, players);
        }

        private Team ReadTeam()
        {
            byte[] teamData = _binaryReader.ReadBytes(TeamParser.DataLength);
            Team team = TeamParser.Parse(teamData);
            return team;
        }

        private Player ReadPlayer()
        {
            byte[] playerData = _binaryReader.ReadBytes(PlayerParser.DataLength);
            Player player = PlayerParser.Parse(playerData);
            return player;
        }

        private static void AssociatePlayerAndTeam(Player player, Team team)
        {
            player.Team = team;
            team.Players.Add(player);
        }
    }
}