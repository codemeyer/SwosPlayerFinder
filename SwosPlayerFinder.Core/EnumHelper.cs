using System;

namespace Manicomio.SwosPlayerFinder.Core
{
    public static class EnumHelper
    {
        public static T Parse<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }
    }
}