using CoolApi.Models;

namespace CoolApi.Services
{
    public interface IHeroService
    {
        IHero GetHero(string id);
    }
    public interface IRatingService
    {
        IRating GetRating(string id);
    }
    public interface IHeroRatingService
    {
        IHeroRating GetHeroRating(string id);
    }
}