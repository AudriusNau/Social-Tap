using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fill_Up_.Fill_Up_
{
    interface ILoadable
    { string name { get; set; }
      int rating { get; set; }
      GlassOfBeer glass { get; set; }

        void LoadData();
        
    }
}
