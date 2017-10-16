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


        public void LoadData(AllBars allbars)
        { 
           
            XmlTextReader reader = new XmlTextReader(@"Data.xml");
           

            
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
                        GlassOfBeer glass = new GlassOfBeer (mug, lackOfBeer, price);
                        Bar bar = new Bar(name, rating, glass);
                        allbars.AddNewBar(bar);
                       
                    }
                    
            }


            
        }
    }
}