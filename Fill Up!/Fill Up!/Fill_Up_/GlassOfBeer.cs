namespace Fill_Up_
{
    public struct GlassOfBeer
    {

        private double orderedQuantity; 
        private int lackOfBeer;
        private decimal price;

        public GlassOfBeer(double orderedQuantity, int lackOfBeer, decimal price)
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
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}