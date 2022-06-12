using System.ComponentModel.DataAnnotations;

namespace ATHHRS.API.Models
{
    public class UpdateHostelDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
    }
}
