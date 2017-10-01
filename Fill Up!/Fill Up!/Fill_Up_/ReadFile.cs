using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Fill_Up_.Fill_Up_
{
    class ReadFile
    { public void ReadingFile()
      {
         XmlReader reader = XmlReader.Create("Data.xml");
            while (reader.Read())
            {
                   if (reader.IsStartElement())
                   {
                        Console.WriteLine("failo pabaiga\n");
                        break;

                        switch (reader.Name.ToString())
                        {
                        case "name":
                            
                          
                        
                    }






                   }

            }
       }
       

    }
}
