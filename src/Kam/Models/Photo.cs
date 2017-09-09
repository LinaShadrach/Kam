using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kam.Models
{
    [Table("Photos")]
    public class Photo
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Approved { get; set; }
        public byte[] Image { get; set; }

    }
}
