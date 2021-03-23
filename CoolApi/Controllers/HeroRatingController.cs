using Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CoolApi.Controllers
{
    [ApiController]
    [Route("hero-ratings")]
    public class HeroRatingsController : ControllerBase
    {
        private readonly IHeroRatingService heroRatingService;

        public HeroRatingsController(IHeroRatingService heroRatingService)
        {
            this.heroRatingService = heroRatingService;
        }

        [Route("{id}")]
        public IActionResult GetHeroRating(string id)
        {
            IHeroRating heroRating = heroRatingService.GetHeroRating(id);
            if (heroRating == null)
            {
                return new StatusCodeResult(404);
            }
            return new JsonResult(heroRating);
        }
    }
}