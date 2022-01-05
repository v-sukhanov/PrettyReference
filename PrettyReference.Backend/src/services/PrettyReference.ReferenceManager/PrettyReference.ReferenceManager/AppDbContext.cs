using Microsoft.EntityFrameworkCore;
using PrettyReference.ReferenceManager.Domain.Db;

namespace PrettyReference.ReferenceManager
{
    public class AppDbContext: DbContext
    {
        public AppDbContext()
        {
            
        }
        public DbSet<ReferenceInformation> ReferenceInformation { get; private set; }
    

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;database=pretty-reference;uid=root;pwd=root",
                    ServerVersion.Parse("8.0"));
                
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }

}