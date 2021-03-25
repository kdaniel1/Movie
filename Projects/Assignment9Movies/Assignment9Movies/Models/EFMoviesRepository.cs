using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment9Movies.Models
{
    public class EFMoviesRepository : IMoviesRepository
    {
        private MoviesContext _context;

        public EFMoviesRepository (MoviesContext context)
        {
            _context = context;
        }

        public IQueryable<Movies> Movies => _context.Movies;
    }
}