using Microsoft.EntityFrameworkCore;

namespace WebPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<StudentClass> tblStudent { get; set; }
    }
}
