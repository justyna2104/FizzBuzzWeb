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

namespace FizzBuzzWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly FizzBuzzContext _context;


        [BindProperty]
        public FizzBuzz Fizzbuzz { get; set;  }

        public IndexModel(ILogger<IndexModel> logger, FizzBuzzContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IList<FizzBuzz> Results { get; set; }
        public void OnGet()
        {
            Results = _context.FizzBuzz.ToList();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("LastChecked", JsonConvert.SerializeObject(Fizzbuzz));

                // tu sie zaczyna crap which i don't understand 
                /*var db = Database.Open("FizzBuzzDB");
                var insertCommand = "INSERT INTO Movies (Title, Genre, Year) VALUES(@0, @1, @2)";
                db.Execute(insertCommand, , genre, year);*/

                return Page();
            }
            return Page();
        }

    }
}
