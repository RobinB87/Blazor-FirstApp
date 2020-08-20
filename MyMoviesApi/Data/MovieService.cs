using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMoviesApi.Data;

namespace MyMoviesApi.Data
{
    public class MovieService
    {
        private readonly MoviesContext _context;
        public MovieService(MoviesContext context)
        {
            _context = context;
        }

    //    public async Task<ActionResult<IEnumerable<Movie>> GetMoviesAsync()
    //    {
    //        return await _context.Movies.Any().ToListAsync();

    //    //// Get Weather Forecasts  
    //    //return await _context.WeatherForecast
    //    //    // Only get entries for the current logged in user
    //    //    .Where(x => x.UserName == strCurrentUser)
    //    //    // Use AsNoTracking to disable EF change tracking
    //    //    // Use ToListAsync to avoid blocking a thread
    //    //    .AsNoTracking().ToListAsync();
    //}
    }
}