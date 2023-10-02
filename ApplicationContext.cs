using EFCoreDay1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDay1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Role>(new RoleConfiguration());
            modelBuilder.ApplyConfiguration<UserRole>(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
            modelBuilder.ApplyConfiguration<Service>(new ServiceConfiguration());
            modelBuilder.ApplyConfiguration<ServiceCategory>(new ServiceCategoryConfiguration());
            modelBuilder.ApplyConfiguration<Request>(new RequestConfiguration());
            modelBuilder.ApplyConfiguration<RequestOffer>(new RequestOfferConfiguratoin());
            modelBuilder.ApplyConfiguration<Media>(new MediaConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.; Initial Catalog=Servmart; Integrated Security=True; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
