namespace Fill_Up_App.Code
{
    public class BarReview : IBarReview
    {
        public string BarName { get; }
        public double OrderedQuantity { get; }
        public int LackOfBeer { get; }
        public double Price { get; }
        public int RatingOfBar { get; }

        public BarReview(string barName, double orderedQuantity, int lackOfBeer, double price, int ratingOfBar)
        {
            BarName = barName;
            OrderedQuantity = orderedQuantity;
            LackOfBeer = lackOfBeer;
            Price = price;
            RatingOfBar = ratingOfBar;
        }
    }
}