namespace ATHHRS.API.Models
{
    public class RoomDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Beds { get; set; }
    }
}
