using CoolApi.Models;

namespace CoolApi.Services
{
    public interface IHeroRatingService
    {
        IHeroRating GetHeroRating(string id);
    }
    public class HeroRatingService : IHeroRatingService
    {
        private readonly IHeroService heroService;
        private readonly IRatingService ratingService;

        public HeroRatingService(
            IHeroService heroService,
            IRatingService ratingService
        ) {
            this.heroService = heroService;
            this.ratingService = ratingService;
        }

        public IHeroRating GetHeroRating(string id)
        {
            IHero hero = heroService.GetHero(id);
            IRating rating = ratingService.GetRating(id);

            if (hero == null || rating == null)
            {
                return null;
            }

            return new HeroRating(
                rating.Id,
                rating.Rate,
                hero.Name
            );
        }
    }
}