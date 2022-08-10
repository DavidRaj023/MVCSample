using MVCSample.Dtos;
using MVCSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCSample.Controllers.Api
{
    public class RentalController : ApiController
    {
        private ApplicationDbContext _context;
        public RentalController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult CreateNewRental(RentalDto rentalDto)
        {
            var customer = _context.Customers.Single(
                c => c.Id == rentalDto.CustomerId);
            //SELECT * FROM Movies WHERE id IN (1, 2, 3)
            var movies = _context.Movies.Where(
                m => rentalDto.MovieIds.Contains(m.Id));

            foreach(var movie in movies)
            {
                var rental = new Rental
                {
                    Customers = customer,
                    Movies = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);

            }
            _context.SaveChanges();

            return Ok();
        }
    }
}
