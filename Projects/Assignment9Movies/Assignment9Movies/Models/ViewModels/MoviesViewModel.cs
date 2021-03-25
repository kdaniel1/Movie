using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Assignment9Movies.Models.ViewModels
{
    public class MoviesViewModel
    {
        public IEnumerable<Movies> Movies { get; set; }
    }
}