namespace LocationAPI.Newage.Models
{
    public class City
    {
        public int Id { get; set; }

        public int CityName { get; set; }

        public State Country { get; set; }
        public long StateId { get; set; }
    }
}