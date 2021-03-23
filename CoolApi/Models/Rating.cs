namespace CoolApi.Models
{
    public interface IRating
    {
        string Id { get; set; }
        double Rate { get; set; }
    }
    class Rating : IRating
    {
        public Rating(string id, double rate)
        {
            Id = id;
            Rate = rate;
        }

        public string Id { get; set; }
        public double Rate { get; set; }
    }
}