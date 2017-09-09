using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kam.Models
{
    [Table("Gifts")]
    public class Gift
    {
        [Key]
        public int Id { get; set; }
    }
}
