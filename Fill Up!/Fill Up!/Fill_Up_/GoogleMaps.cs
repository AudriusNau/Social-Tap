using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fill_Up_.Fill_Up_
{
    public class GoogleMaps : IMap
    {
        public string Name { get { return "GoogleMaps"; } }
        public string Url { get { return FindInMap1.GoogleMaps; } }

        public GoogleMaps() {}
    }
}
