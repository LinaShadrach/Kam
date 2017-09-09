
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Kam.Models
{
    [Table("Abouts")]
    public class About
    {
        [Key]
        public int Id { get; set; }
    }
}
