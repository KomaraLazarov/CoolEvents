using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoolEvents.Data.Entities
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int EventId { get; set; }
        public virtual Events Event { get; set; }

        [Required]
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
