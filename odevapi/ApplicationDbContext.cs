using Microsoft.EntityFrameworkCore;
using odevapi;

namespace odevapi
{
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<MyDataModel> Tablo { get; set; } 

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
    
                modelBuilder.Entity<MyDataModel>().ToTable("tablo");  // sqldeki tablo adı
        }
        }
    }
