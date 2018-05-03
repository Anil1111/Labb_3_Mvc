using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Labb_3_Mvc.Cinema.Models;
using Labb_3_Mvc.Cinema;

namespace Labb_3_Mvc.Controllers
{
    public class CinemaController : Controller
    {
        BookingTicket ticket { get; set; }
        Movie tempmovie { get; set; }
        Room tempRoom { get; set; }
        DateTime date { get; set; }
        string temptstatus { get; set; }
        private readonly BerraContext _context;

        public CinemaController(BerraContext context)
        {
            _context = context;
        }

        // GET: Shows
        public async Task<IActionResult> Index(string SortingOrder)
        {
            ViewBag.NameSortingParm = String.IsNullOrEmpty(SortingOrder) ? "title_desc" : "";
            ViewBag.GenreSortingParm = SortingOrder == "Genre" ? "genre_asc" : "Genre";

            List<Conjunction> view = new List<Conjunction>();

            var context = _context.Conjunction.Include(s => s.Movie).Include(s => s.Room);

            switch (SortingOrder)
            {
                case "title_desc":
                    view = context.OrderByDescending(s => s.Movie.Title).ToList();
                    break;
                case "Genre":
                    view = context.OrderByDescending(s => s.Movie.Genre).ToList();
                    break;
                case "genre_asc":
                    view = context.OrderBy(s => s.Movie.Genre).ToList();
                    break;
                default:
                    view = context.OrderBy(s => s.Movie.Title).ToList();
                    break;
            }

            return View(view);
        }

        public async Task<IActionResult> Movie(int? id)
        {
            var view = _context.Conjunction.Where(m => m.Movie.Id == id).Include(m => m.Movie);

            return View(view);
        }

        [HttpGet]
        public async Task<IActionResult> BookMovie(int? id)
        {
            var view = _context.Conjunction.Where(c => c.Movie.Id == id).Include(c => c.Movie).Include(c => c.Room);

            return View(view);
        }
        [HttpPost]
        public async Task<IActionResult> Thanks(int? id, int seatsInput)
        {
            var movie = _context.Conjunction
                .Where(c => c.Id == id)
                .Include(m => m.Movie);

            foreach (var i in movie)
            {
                i.Movie.SeatsNr -= seatsInput;
            }

            var context = _context.Conjunction
                .Where(c => c.Id == id)
                .Include(m => m.Movie)
                .Include(r => r.Room);

            foreach (var i in context)
            {
                tempmovie = i.Movie;
                tempRoom = i.Room;
                temptstatus = i.Status;
            }

            ticket = new BookingTicket()
            {
                Movie = tempmovie,
                Room = tempRoom,
                BookingDate = DateTime.Now
            };

            _context.Add(ticket);
            await _context.SaveChangesAsync();

            var view = _context.BookingTickets
                .Include(t => t.Movie)
                .Include(t => t.Room).OrderByDescending(t => t.Id).ToList();

            return View(view);

        }
    }
}