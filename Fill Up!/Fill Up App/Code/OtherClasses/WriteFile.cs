using System.Collections.Generic;
using System.Xml;

namespace Fill_Up_App.Code
{
    public class WriteFile : IWriteable
    {
      public void WriteToFile(ListsOfBars obj)
      {
            List<VisitedBar> listOfBars = obj.GetBarList();
            XmlWriter xmlWriter = XmlWriter.Create(@"Data.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Bars");
            xmlWriter.WriteString("\n");
            

            foreach (VisitedBar bar in listOfBars)
            {   xmlWriter.WriteStartElement("Bar");
                xmlWriter.WriteString("\n");

                xmlWriter.WriteStartElement("name");
                xmlWriter.WriteString(bar.Name.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteString("\n");

                xmlWriter.WriteStartElement("mug");
                xmlWriter.WriteString(bar.Glass.OrderedQuantity.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteString("\n");

                xmlWriter.WriteStartElement("lackOfBeer");
                xmlWriter.WriteString(bar.Glass.LackOfBeer.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteString("\n");

                xmlWriter.WriteStartElement("price");
                xmlWriter.WriteString(bar.Glass.Price.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteString("\n");

                xmlWriter.WriteStartElement("price");
                xmlWriter.WriteString(bar.Glass.Price.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteString("\n");

                xmlWriter.WriteStartElement("rating");
                xmlWriter.WriteString(bar.Rating.ToString());
                xmlWriter.WriteEndElement();
                xmlWriter.WriteString("\n");

                xmlWriter.WriteEndElement();
                xmlWriter.WriteString("\n");
            }
            
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}
