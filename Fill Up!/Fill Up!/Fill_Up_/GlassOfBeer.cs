namespace Fill_Up_
{
    public struct GlassOfBeer
    {

        public double orderedQuantity; 
        public int lackOfBeer;
        public decimal price;

        public GlassOfBeer(double orderedQuantity, int lackOfBeer, decimal price)
        {
            this.orderedQuantity = orderedQuantity;
            this.lackOfBeer = lackOfBeer;
            this.price = price;
        }
    }
}