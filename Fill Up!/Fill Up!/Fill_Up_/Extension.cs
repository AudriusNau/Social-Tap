using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fill_Up_.Fill_Up_
{
    public static class Extension
    {
        public static double StringToDouble(this string value)
        {
            return Double.Parse(value);
        }
    }
}
