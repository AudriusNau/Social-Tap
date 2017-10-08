namespace Fill_Up_
{
    public class Bar
    {
        public string Name { get; set; }
        public int Rating { get; set; }
        public GlassOfBeer Glass { get; set; }

        public Bar()
        {
            Name = null;
            Rating = 0;
            Glass = new GlassOfBeer();
        }

        public Bar(string name, int rating, GlassOfBeer glass)
        {
            Name = name;
            Rating = rating;
            Glass = glass;
        }
    }
}