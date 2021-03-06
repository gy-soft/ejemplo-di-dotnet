using System.Collections.Generic;
using Contracts;

namespace CoolApi.Models
{
class Hero : IHero
{
    public Hero() {}
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