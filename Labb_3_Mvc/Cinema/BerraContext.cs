using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labb_3_Mvc.Cinema.Models;

namespace Labb_3_Mvc.Cinema
{
    public class BerraContext : DbContext
    {
        public BerraContext(DbContextOptions options) : base(options) { }

        public DbSet<BookingTicket> BookingTickets { get; set; }
        //public DbSet<Client> Clients { get; set; }
        public DbSet<Conjunction> Conjunction { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
