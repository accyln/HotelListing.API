using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Models
{
    public class TestSuite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string SuiteAdi { get; set; }
        public int ModulId { get; set; }
        public int? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
    }
}
