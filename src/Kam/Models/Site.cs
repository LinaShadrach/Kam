using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kam.Models
{
    [Table("Sites")]
    public class Site
    {
        [Key]
        public int Id { get; set; }
    }
}
