using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstThingsFirst.Models.ViewModels
{
    public class QuadrantViewModel
    {
        public IEnumerable<TaskItem> QuandrantI { get; set; }
        public IEnumerable<TaskItem> QuandrantII { get; set; }
        public IEnumerable<TaskItem> QuandrantIII { get; set; }
        public IEnumerable<TaskItem> QuandrantIV { get; set; }

    }
}
