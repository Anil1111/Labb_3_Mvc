using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_3_Mvc.Cinema.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Column("RoomName")]
        [MaxLength(32)]
        public string RoomName { get; set; }

    }
}
