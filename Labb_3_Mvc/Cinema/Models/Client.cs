using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_3_Mvc.Cinema.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Column("FirstName")]
        [MaxLength(32)]
        public string FirstName { get; set; }
        public int TelephoneNumber { get; set; }

        public virtual Room Room { get; set; }
        public virtual Movie Movie { get; set; }

        public virtual IEnumerable<BookingTicket> BookingTicket { get; set; }
    }
}
