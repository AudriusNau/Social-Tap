using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Fill_Up_.Fill_Up_
{
    class  ReadFile: ILoadable
    {

        public string name { get; set; }
        public int rating { get; set; }
        private double mug;
        private int lackOfBeer;
        private decimal price;
        public GlassOfBeer glass { get; set; }
        public void LoadData()
        { 
           
            XmlTextReader reader = new XmlTextReader(@"Data.xml");
            GlassOfBeer glass = new GlassOfBeer();

            
            using (System.IO.StreamWriter writer = 
                new System.IO.StreamWriter(@"Rez.txt", false))
                
            while (reader.Read())
            {
                    if (reader.NodeType== XmlNodeType.Element)
                    {
                           
                        switch (reader.Name)
                        { case "name":
                                this.name=reader.ReadElementContentAsString();

                                break;
                            case "mug":
                                this.mug= reader.ReadElementContentAsDouble();
                                break;

                            case "lackOfBeer":
                                this.lackOfBeer = reader.ReadElementContentAsInt();
                                break;

                            case "price":
                                this.price = reader.ReadElementContentAsDecimal();
                                break;
                            case "rating":
                                this.rating = reader.ReadElementContentAsInt();
                                break;
                        }
                    }
                    if (reader.NodeType== XmlNodeType.EndElement && reader.Name=="bar")
                        {
                        //glass.GlassOfBeer(mug, lackOfBeer, price);
                    }
                    
            }


           
        }
    }
}