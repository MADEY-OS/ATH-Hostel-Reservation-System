namespace ATHHRS.API.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Beds { get; set; }
        public int HostelId { get; set; }
        public Hostel Hostel { get; set; }
        public List<Rent> Rents { get; set; }
    }
}
