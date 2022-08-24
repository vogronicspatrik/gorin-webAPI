


using GorinWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GorinWebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }


        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
