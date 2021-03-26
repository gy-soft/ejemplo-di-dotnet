using System.Threading.Tasks;
using Contracts;
using CoolApi.Models;

namespace CoolApi.Services
{
    class HeroRatingService : IHeroRatingService
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

        public async Task<IHeroRating> GetHeroRating(string id)
        {
            IHero hero = await heroService.GetHeroAsync(id);
            IRating rating = ratingService.GetRating(id);

            if (hero == null || rating == null)
            {
                return null;
            }

            return new HeroRating(
                hero, rating
            );
        }
    }
}