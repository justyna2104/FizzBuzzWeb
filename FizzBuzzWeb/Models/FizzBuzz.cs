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
        public int id { get; set; }

        public int userId { get; set; }

        public AspNetUsers User { get; set; }

        [Display(Name = "Enter your value ")]
        [Range(1, 1000, ErrorMessage = "Number out of range. Try again"), Required(ErrorMessage = "This value is required")]
        public int value { get; set; }

        //[Required]
        //[MaxLength(100)]
        public string result { get; set; } = "";

        //[Required]
        public DateTime time { get; set; } = DateTime.Now;

        public string Result()
        {
            

                if (value % 3 == 0)
                {
                    result += "Fizz";

                }
                if (value % 5 == 0)
                {
                    result += "Buzz";
                }
            if (value % 5 != 0 && value % 3 != 0)
            {
                result = "The number is not Fizz, Buzz or Fizzbuzz";

            }

            return result;
        }

      
    }


}
