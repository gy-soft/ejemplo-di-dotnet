using System.Threading.Tasks;
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
        public async Task<IActionResult> GetHeroRatingAsync(string id)
        {
            IHeroRating heroRating = await heroRatingService.GetHeroRatingAsync(id);
            if (heroRating == null)
            {
                return new StatusCodeResult(404);
            }
            return new JsonResult(heroRating);
        }
    }
}