using System;
using System.Text;

namespace Manicomio.SwosPlayerFinder.Core
{
    public static class PlayerParser
    {
        public const int DataLength = 38;

        public static Player Parse(byte[] playerData)
        {
            var player = new Player();

            player.Name = GetName(playerData);
            player.Nationality = Countries.GetPlayerCountry(playerData[0]);
            player.Position = GetPosition(playerData);
            player.Skills = GetSkills(playerData);
            player.Value = GetValue(playerData);

            return player;
        }

        private static string GetName(byte[] playerData)
        {
            byte[] nameBytes = new byte[23];
            Array.Copy(playerData, 3, nameBytes, 0, 23);

            string name = Encoding.ASCII.GetString(nameBytes);
            name = name.Replace("\0", string.Empty);
            name = name.Trim();

            return name;
        }

        private static Position GetPosition(byte[] playerData)
        {
            var positionParser = new PositionParser();
            return positionParser.GetPosition(playerData[26]);
        }

        private static Skills GetSkills(byte[] playerData)
        {
            var skillsParser = new SkillsParser(); 
            return skillsParser.Parse(playerData[28], playerData[29], playerData[30], playerData[31]);
        }

        private static int GetValue(byte[] playerData)
        {
            var valueParser = new ValueParser();
            return valueParser.GetValue(playerData[32]);
        }
    }
}