using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kam.Models
{
    [Table("Sections")]
    public class Section
    {
        [Key]
        public int Id { get; set; }
    }
}
