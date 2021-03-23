namespace CoolApi.Models
{
    public interface IHeroRating : IRating
    {
        string Name { get; set; }
    }
    class HeroRating : IHeroRating
    {
        public HeroRating(string id, double rate, string name)
        {
            Id = id;
            Rate = rate;
            Name = name;
        }

        public string Id { get; set; }
        public double Rate { get; set; }
        public string Name { get; set; }
    }
}