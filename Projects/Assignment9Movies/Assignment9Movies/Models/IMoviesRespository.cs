using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment9Movies.Models
{
    public interface IMoviesRepository
    {
        IQueryable<Movies> Movies { get; }
    }    
}
