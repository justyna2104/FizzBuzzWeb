using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;


namespace FizzBuzzWeb.Models
{
   
    public class FizzBuzz
    {
        [Display(Name = "Enter your value ")]
        [Range(1, 1000, ErrorMessage = "Number out of range. Try again"), Required(ErrorMessage = "This value is required")]
        public int value { get; set; }
    }

 

}
