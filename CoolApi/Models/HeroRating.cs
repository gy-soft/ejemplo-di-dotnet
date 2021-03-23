namespace CoolApi.Models
{
    class HeroRating : IHeroRating
    {
        public HeroRating(IHero hero, IRating rating)
        {
            Id = hero.Id;
            Name = hero.Name;
            Rate = rating.Rate;
        }

        public string Id { get; set; }
        public double Rate { get; set; }
        public string Name { get; set; }
    }
}