using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Contracts;
using CoolApi.Models;

namespace CoolApi.Services
{
    class HeroService : IHeroService
    {
        public HttpClient Client { get; }

        public HeroService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new System.Uri("http://127.0.0.1:3000");
            Client = httpClient;
        }

        public async Task<IHero> GetHero(string id)
        {
            var response = await Client.GetAsync($"/heroes/{id}");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return await Task.FromResult(default(IHero));
            }
            string content = await response.Content.ReadAsStringAsync();
            var hero = JsonSerializer.Deserialize<Hero>(content, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });
            return hero;
        }
    }
}