using System;
using System.Text;

namespace Manicomio.SwosPlayerFinder.Core
{
    public static class TeamParser
    {
        public const int DataLength = 76;

        public static Team Parse(byte[] teamData)
        {
            var team = new Team();

            team.Nationality = Countries.GetTeamCountry(teamData[0]);
            team.Name = GetName(teamData);

            return team;
        }

        private static string GetName(byte[] teamData)
        {
            byte[] nameBytes = new byte[25];
            Array.Copy(teamData, 5, nameBytes, 0, 25);

            string name = Encoding.ASCII.GetString(nameBytes);
            name = name.Replace("\0", string.Empty);
            name = name.Trim();

            return name;
        }
    }
}