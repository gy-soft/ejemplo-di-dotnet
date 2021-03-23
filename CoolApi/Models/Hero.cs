using System.Collections.Generic;

namespace CoolApi.Models
{
    class Hero : IHero
    {
        public Hero(string id, string name, IEnumerable<string> friends)
        {
            Id = id;
            Name = name;
            Friends = friends;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Friends { get; set; }
    }
}