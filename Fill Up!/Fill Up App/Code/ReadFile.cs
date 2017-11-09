using System.Xml;

namespace Fill_Up_App.Code
{
    public  class ReadFile : ILoadable
    {
        private string name;
        private int rating;
        private double mug;
        private int lackOfBeer;
        private decimal price;
        
        public void ReadData(ListsOfBars allbars)
        { 
            XmlTextReader reader = new XmlTextReader(@"Data.xml");
        
            while (reader.Read())
            {
                    if (reader.NodeType== XmlNodeType.Element)
                    {                           
                        switch (reader.Name)
                        { 
                            case "name":
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
                    
                    if (reader.NodeType== XmlNodeType.EndElement && reader.Name=="Bar") 
                    {
                        LoadToList(allbars, name, rating, mug, lackOfBeer, price);                                
                    }
            }
            reader.Close();
        }

        public void LoadToList (ListsOfBars allbars, string name, int rating, double mug, int lackOfBeer, decimal price)
        {
            double pr = (double)price;
            GlassOfBeer glass = new GlassOfBeer (mug, lackOfBeer, pr); //sudeda nuskaitytus duomenis i lista
            VisitedBar bar = new VisitedBar(name, rating, glass);
            allbars.AddNewBar(bar);    
        }
    }
}