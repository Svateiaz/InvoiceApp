using Microsoft.EntityFrameworkCore;

namespace ReactApp2.Server.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("T_CFG_USERS"); // Specify your actual table name here
            modelBuilder.Entity<Address>()
                .ToTable("T_ADDRESS");
        }
    }
}
