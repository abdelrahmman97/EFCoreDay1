using EFCoreDay1.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDay1
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageMedia> MessageMedias { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductMedia> ProductMedias { get; set; }
        public DbSet<ProductRate> ProductRates { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestMedia> RequestMedias { get; set; }
        public DbSet<RequestOffer> RequestOffers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<ServiceRate> ServiceRates { get; set; }
        public DbSet<Shop> Shops { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Role>(new RoleConfiguration());
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
            modelBuilder.ApplyConfiguration<UserRole>(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration<Chat>(new ChatConfiguration());
            modelBuilder.ApplyConfiguration<Message>(new MessageConfiguration());
            modelBuilder.ApplyConfiguration<MessageMedia>(new MessageMediaConfiguration());
            modelBuilder.ApplyConfiguration<Product>(new ProductConfigurstion());
            modelBuilder.ApplyConfiguration<ProductCategory>(new ProductCategoryConfigurstion());
            modelBuilder.ApplyConfiguration<ProductMedia>(new ProductMediaConfiguration());
            modelBuilder.ApplyConfiguration<ProductRate>(new ProductRateconfigurstion());
            modelBuilder.ApplyConfiguration<Request>(new RequestConfiguration());
            modelBuilder.ApplyConfiguration<RequestMedia>(new RequestMediaConfiguration());
            modelBuilder.ApplyConfiguration<RequestOffer>(new RequestOfferConfiguratoin());
            modelBuilder.ApplyConfiguration<Service>(new ServiceConfiguration());
            modelBuilder.ApplyConfiguration<ServiceCategory>(new ServiceCategoryConfiguration());
            modelBuilder.ApplyConfiguration<ServiceRate>(new ServiceRateConfiguration());
            modelBuilder.ApplyConfiguration<Shop>(new ShopConfigtstion());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.; Initial Catalog=Servmart; Integrated Security=True; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
