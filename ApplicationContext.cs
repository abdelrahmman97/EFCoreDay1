using EFCoreDay1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDay1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<RequestMedia> RequestMedias { get; set; }
        public DbSet<ProductMedia> ProductMedias { get; set; }
        public DbSet<ProductRate> ProductRates { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestOffer> requestOffers { get; set; }
        public DbSet<shop> Shops { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Category>(new Categoryconfigurstion());
            modelBuilder.ApplyConfiguration<RequestMedia>(new RequestMediaConfiguration());
            modelBuilder.ApplyConfiguration<ProductMedia>(new ProductMediaConfiguration());
            modelBuilder.ApplyConfiguration<ProductRate>(new ProductRateconfigurstion());
            modelBuilder.ApplyConfiguration<Product>(new ProductconfigurstionBase());
            modelBuilder.ApplyConfiguration<Request>(new RequestConfiguration());
            modelBuilder.ApplyConfiguration<RequestOffer>(new RequestOfferConfiguratoin());
            modelBuilder.ApplyConfiguration<Role>(new RoleConfiguration());
            modelBuilder.ApplyConfiguration<RequestMedia>(new RequestMediaConfiguration());
            modelBuilder.ApplyConfiguration<Service>(new ServiceConfiguration());
            modelBuilder.ApplyConfiguration<ServiceCategory>(new ServiceCategoryConfiguration());
            modelBuilder.ApplyConfiguration<UserRole>(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.; Initial Catalog=Servmart; Integrated Security=True; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
