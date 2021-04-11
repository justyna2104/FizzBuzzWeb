using FizzBuzzWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FizzBuzzWeb.Data
{
    public class FizzBuzzContext : DbContext
    {

        public FizzBuzzContext(DbContextOptions options) : base(options) { }

        public DbSet<FizzBuzz> FizzBuzz { get; set; }
        
    }
}
