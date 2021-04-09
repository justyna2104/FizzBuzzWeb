using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzzWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;

namespace FizzBuzzWeb.Pages
{
    public class LastCheckedModel : PageModel
    {
        public FizzBuzz FizzBuzz { get; set; }
        public void OnGet()
        {
            var SessionFizzbuzz =
            HttpContext.Session.GetString("LastChecked"); // here must be the same name as in Index.cshtml.cs OnPost() (SetString)
            if (SessionFizzbuzz != null)
                FizzBuzz = JsonConvert.DeserializeObject<FizzBuzz>(SessionFizzbuzz);
        }
    }
}
