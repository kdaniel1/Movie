using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstThingsFirst.Models;
using FirstThingsFirst.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstThingsFirst.Controllers
{
    public class HomeController : Controller
    {
        private TaskListContext context { get; set; }

        //create a constructor, only called when the home controller is created/run for the first time
        public HomeController(TaskListContext con)
        {
            context = con;  
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            // commenting this out because we are going to seperate it by element
            // instead of just printing them all on the index page
            //return View("Index", context.Tasks);
            return View(new QuadrantViewModel
            {
             QuandrantI = context.Tasks
             .Where(x=> x.Urgent == true && x.Important == true),

             QuandrantII = context.Tasks
             .Where(x => x.Urgent == false && x.Important == true),

             QuandrantIII = context.Tasks
             .Where(x => x.Urgent == true && x.Important == false),

             QuandrantIV = context.Tasks
             .Where(x => x.Urgent == false && x.Important == false)
            });
        }

        [HttpGet]
        public IActionResult EnterTask()
        {
            return View();
        }
        [HttpPost]
        public IActionResult EnterTask(TaskItem t)
        {
            if (ModelState.IsValid)
            {
                //update database
                context.Tasks.Add(t);
                context.SaveChanges();
            }
            return View();
        }
    }
}
