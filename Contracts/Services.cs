using System.Threading.Tasks;

namespace Contracts
{
    public interface IHeroService
    {
        Task<IHero> GetHero(string id);
    }
    public interface IRatingService
    {
        IRating GetRating(string id);
    }
    public interface IHeroRatingService
    {
        Task<IHeroRating> GetHeroRating(string id);
    }
}