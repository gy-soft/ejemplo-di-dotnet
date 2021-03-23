using CoolApi.Models;

namespace CoolApi.Services
{
    public interface IHeroRatingService
    {
        HeroRating GetHeroRating(string id);
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

        public HeroRating GetHeroRating(string id)
        {
            Hero hero = heroService.GetHero(id);
            Rating rating = ratingService.GetRating(id);

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