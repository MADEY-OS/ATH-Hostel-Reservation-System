using ATHHRS.API.Entities;

namespace ATHHRS.API.Models
{
    public class HostelDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
        public string ImageUrl { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public  List<RoomDto> Rooms { get; set; }
    }
}
