using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstThingsFirst.Models
{
    public class TaskItem
    {
        [Key]
        [Required]
        public int TaskId { get; set; }

        [Required]
        public string TaskDescription { get; set; }

        [Required]
        public bool Urgent { get; set; }

        [Required]
        public bool Important { get; set; }

        public string GetQuadrant()
        {
            string quandrantName = "";

            //if (Urgent == true && Important == true)
            if (Urgent && Important)
            {
                quandrantName = "Q1";
            }
            else if (!Urgent && Important)
            {
                quandrantName = "Q2";
            }
            else if (Urgent && !Important)
            {
                quandrantName = "Q3";
            }
            else if (!Urgent && !Important)
            {
                quandrantName = "Q4";
            }
            return quandrantName;
        }

    }
}
