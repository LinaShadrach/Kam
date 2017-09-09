using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Kam.Models
{
    [Table("Guests")]
    public class Guest
    {
        [Key]
        public int Id { get; set; }
    }
}
