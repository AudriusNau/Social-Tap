namespace Fill_Up_
{
    public class Bar
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public GlassOfBeer Glass { get; set; }

        public Bar(string name, int rating, GlassOfBeer glass)
        {
            Name = name;
            Rating = rating;
            Glass = glass;
        }
    }
}