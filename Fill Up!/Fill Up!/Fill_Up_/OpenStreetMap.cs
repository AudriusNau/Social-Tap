using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fill_Up_.Fill_Up_
{
    public class OpenStreetMap : IMap
    {
        public string Name { get { return "OpenStreetMap"; } }
        public string Url { get { return FindInMap1.OpenStreetMap; } }

        public OpenStreetMap() {}
    }
}
