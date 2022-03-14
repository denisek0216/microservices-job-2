namespace TaxiBookingApi.Models
{
    public class Booking
    {
        public long Id { get; set; }
        public string? Date { get; set; }
        public string? Time { get; set; }
        public string? PickupPoint { get; set; }
        public string? Destination { get; set; }
        public double CurrentLocation_Latitude { get; set; }
        public double CurrentLocation_Longitude { get; set; }
    }
}