using BookMyShowBussiness.services;
using BookMyShowEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace MovieAppCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private MovieService _movieService;
        public MoviesController(MovieService movieService)
        {
            _movieService = movieService;
        }
        [HttpGet("GetMovies")]
        public IEnumerable<Movie> GetMovies()
        {
            return _movieService.GetMovies();
        }

        [HttpPost("AddMovie")]
        public IActionResult AddMovie([FromBody] Movie movie)
        {
            _movieService.AddMovie(movie);
            return Ok("Movie created successfully!!");
        }
        [HttpDelete("DeleteMovie")]
        public IActionResult DeleteMovie(int movieId)
        {
            _movieService.DeleteMovie(movieId);
            return Ok("Movie deleted successfully!!");
        }
        [HttpPut("UpdateMovie")]
        public IActionResult UpdateMovie([FromBody] Movie Movie)
        {
            _movieService.UpdateMovie(Movie);
            return Ok("Movie updated successfully!!");
        }
    }
}
