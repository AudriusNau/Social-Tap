using System;
using System.Globalization;

namespace Fill_Up_.Code
{
    public static class Extension
    {
        public static double StringToDouble(this string value)
        {
            return Convert.ToDouble(value, CultureInfo.InvariantCulture);
        }

        public static int StringToInt(this string value)
        {
            return (int)Math.Round(value.StringToDouble());
        }

        public static decimal StringToDecimal(this string value)
        {
            return Convert.ToDecimal(value);
        }

        public static double DecimalToDouble(this decimal value)
        {
            return Convert.ToDouble(value, CultureInfo.InvariantCulture);
        }

        public static decimal DoubleToDecimal(this double value)
        {
            return Convert.ToDecimal(value);
        }
    }
}
