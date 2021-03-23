using System.Collections.Generic;

namespace CoolApi.Models
{
    public class Hero
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