using System;
namespace Fill_Up_.Code
{
    public static class Extension
    {
        public static double StringToDouble(this string value)
        {
            return Double.Parse(value);
        }
    }
}
