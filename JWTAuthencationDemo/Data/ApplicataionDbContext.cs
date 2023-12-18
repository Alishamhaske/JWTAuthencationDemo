using JWTAuthencationDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace JWTAuthencationDemo.Data
{
    public class ApplicataionDbContext:DbContext
    {

        public ApplicataionDbContext(DbContextOptions<ApplicataionDbContext> options)
            : base(options) { } 

        public DbSet<Book> Books { get; set; }
    }
}
