using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_3_Mvc.Cinema.Models
{
    public class Conjunction
    {
        [Key]
        public int Id { get; set; }
        public Movie Movie { get; set; }
        public Room Room { get; set; }
        public DateTime MovieTime { get; set; }
    }
}
