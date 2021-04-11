using FizzBuzzWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FizzBuzzWeb.Data
{
    public class FizzBuzzContext : DbContext
    {
        public DbSet<FizzBuzz> FizzBuzz { get; set; }
        
    }
}
