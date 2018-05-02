using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_3_Mvc.Cinema.Models
{
    public class Conjunction
    {
        [Key]
        public int Id { get; set; }

        [Column("Status")]
        [MaxLength(32)]
        public string Status { get; set; }

        public Movie Movie { get; set; }

        public Room Room { get; set; }

        //public BookingTicket TicketId { get; set; }
        //public DateTime MovieTime { get; set; }
        //public Client Client { get; set; }
        //public Movie Movie { get; set; }
    }
}
