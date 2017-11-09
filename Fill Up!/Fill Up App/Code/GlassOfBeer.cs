namespace Fill_Up_App.Code
{
    public struct GlassOfBeer
    {

        private double orderedQuantity; 
        private int lackOfBeer;
        private double price;

        public GlassOfBeer(double orderedQuantity, int lackOfBeer, double price)
        {
            this.orderedQuantity = orderedQuantity;
            this.lackOfBeer = lackOfBeer;
            this.price = price;
        }
        public double OrderedQuantity
        {
            get { return orderedQuantity; }
            set { orderedQuantity = value; }
        }
        public int LackOfBeer
        {
            get { return lackOfBeer; }
            set { lackOfBeer = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}