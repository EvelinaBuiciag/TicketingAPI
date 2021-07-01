using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Models
{
    public class Ticket
    {
        public int? TicketId { get; set; }
        [Required]
        public int? OwnerId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int BuyerId { get; set; }
        public Owner Owner { get; set; }
        public Owner Buyer { get; set; }
    }
}
