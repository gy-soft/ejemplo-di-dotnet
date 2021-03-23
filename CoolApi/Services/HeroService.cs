using System.Collections.Generic;
using CoolApi.Models;

namespace CoolApi.Services
{
    public interface IHeroService
    {
        Hero GetHero(string id);
    }
    public class HeroService : IHeroService
    {
        private readonly IDictionary<string, Hero> _heroes = new Dictionary<string, Hero>();

        public HeroService()
        {
            _heroes.Add("r2", new Hero("r2", "R2-D2", new string[] { "luke", "kenobi" }));
            _heroes.Add("solo", new Hero("solo", "han Solo", new string[] { "Leia", "luke" }));
            _heroes.Add("luke", new Hero("luke", "Luke Skywaler", new string[] { "r2", "kenobi", "solo" }));
        }

        public Hero GetHero(string id)
        {
            return _heroes.ContainsKey(id)
                ? _heroes[id]
                : default(Hero);
        }
    }
}