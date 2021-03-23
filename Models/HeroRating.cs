namespace CoolApi.Models
{
    public class HeroRating : Rating
    {
        public HeroRating(string id, double rate, string name) : base(id, rate)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}