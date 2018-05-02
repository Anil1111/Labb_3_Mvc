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

        public async Task<IActionResult> BookMovie(int? id)
        {
            var view = _context.Conjunction.Where(c => c.Movie.Id == id).Include(c => c.Movie).Include(c => c.Room);

            return View(view);
        }

        public async Task<IActionResult> Thanks(int? id, string nameInput, string emailInput, string telInput, int seatsInput)
        {
            var view = _context.Conjunction.Where(c => c.Movie.Id == id).Include(c => c.Movie).Include(c => c.Room);

            return View(view);

        }
    }
}