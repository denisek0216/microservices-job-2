namespace taxiBookingApi.Models
{
    public class Booking
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string? PickupPoint { get; set; }
        public string? Destination { get; set; }
        public float CurrentLocation_Latitude { get; set; }
        public float CurrentLocation_Longitude { get; set; }
    }
}