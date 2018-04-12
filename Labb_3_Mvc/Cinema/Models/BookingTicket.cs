using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_3_Mvc.Cinema.Models
{
    public class BookingTicket
    {
        [Key]
        public int Id { get; set; }

        public Client ClientInfo { get; set; }
        public DateTime BookingDate { get; set; }
        public Movie MovieInfo { get; set; }
        public Room RoomInfo { get; set; }
    }
}
