using System.Collections.Generic;
using Contracts;
using CoolApi.Models;

namespace CoolApi.Services
{
    class RatingService : IRatingService
    {
        private readonly IDictionary<string, Rating> _ratings = new Dictionary<string, Rating>();

        public RatingService()
        {
            _ratings.Add("r2", new Rating("r2", 4.99));
            _ratings.Add("luke", new Rating("luke", 3.89));
            _ratings.Add("solo", new Rating("solo", 4.57));
            _ratings.Add("kenobi", new Rating("kenobi", 4.68));
            _ratings.Add("leia", new Rating("leia", 4.32));
        }

        public IRating GetRating(string id)
        {
            return _ratings.ContainsKey(id)
                ? _ratings[id]
                : default(Rating);
        }
    }
}