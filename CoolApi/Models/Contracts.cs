namespace CoolApi.Models
{
    public interface IHero
    {
        string Id { get; set; }
        string Name { get; set; }
    }
    public interface IRating
    {
        string Id { get; set; }
        double Rate { get; set; }
    }
    public interface IHeroRating : IRating
    {
        string Name { get; set; }
    }
}