using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_Task_1.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Please provie Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provie Name")]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Please provie Description")]
        public string Description { get; set; }
    }
}