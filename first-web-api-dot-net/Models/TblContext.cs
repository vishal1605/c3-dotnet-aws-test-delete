using Microsoft.EntityFrameworkCore;

namespace first_web_api_dot_net.Models
{
    public class TblContext : DbContext
    {
        public TblContext()
        {
        }
        public TblContext(DbContextOptions<TblContext> option) : base(option)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    // Configure one-to-many relationship
        //    modelBuilder.Entity<User>()
        //        .HasMany(u => u.Roles)
        //        .WithOne(r => r.User)
        //        .HasForeignKey(r => r.UserId)
        //        .IsRequired(false);

        //    base.OnModelCreating(modelBuilder);
        //}

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleName> RoleName { get; set; }
    }
}
