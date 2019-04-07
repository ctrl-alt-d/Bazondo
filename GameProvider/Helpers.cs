using System;

namespace Blazondo.Questions
{
    
    public static class Helpers
    {
        public static T ToEnum<T>(this string value)
        {
            return (T) Enum.Parse(typeof(T), value, true);
        }

    }
}