using System;

namespace Manicomio.SwosPlayerFinder.Core
{
    public class PositionParser
    {
        public Position GetPosition(byte positionValue)
        {
            int val = Convert.ToInt32(positionValue);

            val >>= 4;

            if (val % 2 != 0)
            {
                val--;
            }
            
            var position = EnumHelper.Parse<Position>(val.ToString());

            return position;
        }
    }
}