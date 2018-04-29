using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_3_Mvc.Cinema.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Column("Title")]
        [MaxLength(32)]
        public string Title { get; set; }

        [Column("Genre")]
        [MaxLength(32)]
        public string Genre { get; set; }

        [Column("ImgUrl")]
        [MaxLength(32)]
        public string Imgurl { get; set; }

        public int AgeRange { get; set; }
    }
}
