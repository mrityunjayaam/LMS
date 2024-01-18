using LMS.Models;
using Microsoft.EntityFrameworkCore;

namespace LMS.context
{
    public class ApplicationDbContext :DbContext
    {
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions)
            : base(contextOptions)
        { 

        }
        public DbSet<Book> Books {
            get; set;
        }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
