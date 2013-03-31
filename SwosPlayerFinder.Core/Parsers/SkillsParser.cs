using System;

namespace Manicomio.SwosPlayerFinder.Core
{
    public class SkillsParser
    {
        public Skills Parse(byte passing, byte shootingHeading, byte tacklingControl, byte speedFinishing)
        {
            var skills = new Skills();

            skills.Passing = GetFirstPartOfByte(passing);
            skills.Shooting = GetSecondPartOfByte(shootingHeading);
            skills.Heading = GetFirstPartOfByte(shootingHeading);
            skills.Tackling = GetSecondPartOfByte(tacklingControl);
            skills.Control = GetFirstPartOfByte(tacklingControl);
            skills.Speed = GetSecondPartOfByte(speedFinishing);
            skills.Finishing = GetFirstPartOfByte(speedFinishing);

            return skills;
        }

        private int GetFirstPartOfByte(byte orig)
        {
            int val = Convert.ToInt32(orig) & 7;

            // takes the original value and ANDs it with 7, thereby discarding the 8,16,32,64,128 bits...
            // e.g. 219 = 3

            return val + 1;
        }
        
        private int GetSecondPartOfByte(byte orig)
        {
            // takes the original value and shifts it down by 4 bits, then ANDs it with 7, thereby discarding the 8,16,32,64,128 bits...

            int val = Convert.ToInt32(orig);
            val >>= 4;
            val = val & 7;

            return val + 1;
        }
    }
}