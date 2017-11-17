namespace Fill_Up_App.Code
{
    public interface IBarReview
    {
        string BarName { get; }
        double OrderedQuantity { get; }
        int LackOfBeer { get; }
        double Price { get; }
        int RatingOfBar { get; }
    }
}