using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;
using Vidly.ViewModel;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        //GET: Movies/Random
        public IActionResult Random()
        {

            var movie = new Movie { Name = "Shrek!"};
            var customers = new List<Customer> { 
                new Customer{ Name = "John" } 
            };

            var moviesRandomViewModel = new MoviesRandomViewModel
            {
                Movie = movie,
                Customers = customers
            };



            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model = moviesRandomViewModel; 
            //return viewResult; 
            
            return View(moviesRandomViewModel); //Returns Views/Movies/Random.cshtml


        }

        [Route("movies/releaseDate/{year}/{month}")]
        public IActionResult ByReleaseDate(int year, int month) 
        {
            return Content($"The requested Release Date: {month} month, {year}"); 
        }
    }
}
