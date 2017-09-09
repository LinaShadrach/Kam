using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kam.Models
{
    [Table("Photo_Positions")]
    public class Photo_Position
    {
        [Key]
        public int Id { get; set; }
    }
}
