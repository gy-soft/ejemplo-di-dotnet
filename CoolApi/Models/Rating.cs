namespace CoolApi.Models
{
    public class Rating
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