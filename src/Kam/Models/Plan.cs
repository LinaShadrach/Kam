using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kam.Models
{
    [Table("Plans")]
    public class Plan
    {
        [Key]
        public int Id { get; set; }
    }
}
