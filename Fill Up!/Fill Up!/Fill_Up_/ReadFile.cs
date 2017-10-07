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
    {
        public static void ReadingFile()
        {
            XmlTextReader reader = new XmlTextReader(@"C:\Users\audri\source\repos\Social-Tap\Fill Up!\Fill Up!\Fill_Up_\Data.xml");
            using (System.IO.StreamWriter writer = 
                new System.IO.StreamWriter(@"C:\Users\audri\source\repos\Social-Tap\Fill Up!\Fill Up!\Fill_Up_\Rez.txt", false))

                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element: // The node is an element.
                            writer.Write("<" + reader.Name);
                            writer.Write(">");
                            break;
                        case XmlNodeType.Text: //Display the text in each element.
                            writer.Write(reader.Value);
                            break;
                        case XmlNodeType.EndElement: //Display the end of the element.
                            writer.Write("</" + reader.Name);
                            writer.WriteLine(">");
                            break;
                    }
                }
            


        }
    }
}