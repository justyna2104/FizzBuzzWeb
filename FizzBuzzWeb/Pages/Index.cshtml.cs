using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using FizzBuzzWeb.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using FizzBuzzWeb.Utils;

namespace FizzBuzzWeb.Pages
{

    [CustomFilterAttributes]
    public class IndexModel : PageModel
    {
        private FizzBuzzContext fizzBuzzContext;

        private readonly ILogger<IndexModel> _logger;

        


        [BindProperty]
        public FizzBuzz Fizzbuzz { get; set;  }

        public IndexModel(ILogger<IndexModel> logger, FizzBuzzContext context)
        {
            _logger = logger;
            fizzBuzzContext = context;
            
        }

        public IList<FizzBuzz> Results { get; set; }
        public void OnGet()
        {
           // Results = fizzBuzzContext.FizzBuzz.ToList();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("LastChecked", JsonConvert.SerializeObject(Fizzbuzz));

                Fizzbuzz.result = Fizzbuzz.Result();
                fizzBuzzContext.Add(Fizzbuzz);
                fizzBuzzContext.SaveChanges();
                Fizzbuzz.result = "";
                return Page();
            }
            return Page();
        }


     

    }
}
