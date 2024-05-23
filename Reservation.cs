namespace HotelManagementSystem
{
    public class Reservation
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
