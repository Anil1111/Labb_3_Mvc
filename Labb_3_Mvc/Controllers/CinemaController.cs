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
        private readonly BerraContext _context;

        public CinemaController(BerraContext context)
        {
            _context = context;
        }

        // GET: Shows
        public async Task<IActionResult> Index(string SortingOrder)
        {
            ViewBag.TimeOrder = SortingOrder == "time_desc" ? "time_asc" : "time_desc";
            ViewBag.SeatsOrder = SortingOrder == "seats_desc" ? "seats_asc" : "seats_desc";

            List<Conjunction> view = new List<Conjunction>();

            var context = _context.Conjunction.Include(s => s.Movie).Include(s => s.Room);

            switch (SortingOrder)
            {
                case "time_desc":
                    view = context.OrderByDescending(s => s.MovieTime).ToList();
                    break;
                case "time_asc":
                    view = context.OrderBy(s => s.MovieTime).ToList();
                    break;
                case "seats_desc":
                    view = context.OrderByDescending(s => s.Room.Seats).ToList();
                    break;
                case "seats_asc":
                    view = context.OrderBy(s => s.Room.Seats).ToList();
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
    }
}