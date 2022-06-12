namespace ATHHRS.API.Entities
{
    public class Rent
    {
        public int Id { get; set; }
        public DateTime RentOrderTime { get; set; }
        public DateTime RentBegin { get; set; }
        public DateTime RentEnd { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
    }
}
