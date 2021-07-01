using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Owner
    {
        public int OwnerId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
