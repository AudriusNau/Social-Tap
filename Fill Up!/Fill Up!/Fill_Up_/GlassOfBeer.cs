namespace Fill_Up_
{
    internal class GlassOfBeer
    {

        private double orderedQuantity;
        private int lackOfBeer;
        private double price;

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