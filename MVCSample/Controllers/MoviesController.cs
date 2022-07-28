using MVCSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movies> GetMovies()
        {
            return new List<Movies>()
            {
                new Movies{ Id = 1, Name = "Vikram"},
                new Movies{ Id = 2, Name = "KGF"},
                new Movies{ Id = 3, Name = "RRR"},
                new Movies{ Id = 4, Name = "Surarai Potru"}
            };
        }
    }

}