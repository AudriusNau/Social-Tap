using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Fill_Up_.Fill_Up_
{
    class WriteFile : IWriteable
    {
        public void WriteData(ListsOfBars allbars)
        {
            XmlWriter xmlWriter = XmlWriter.Create("test.xml");

            xmlWriter.WriteStartDocument();

        }
    }
}
