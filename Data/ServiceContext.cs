using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Data
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options) { }
        public DbSet<ProductItem> Products { get; set; }
        public DbSet<OrderItem> Orders { get; set; }
        public DbSet<UserItem> Users { get; set; }
        public DbSet<AdminItem> Admins { get; set; }
        public DbSet<BuyerItem> Buyers { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ProductItem>()
            .ToTable("Products");

            builder.Entity<OrderItem>()
            .ToTable("Orders")
            .HasOne<ProductItem>()
            .WithMany()
            .HasForeignKey(o => o.ProductNum);

            builder.Entity<UserItem>()
            .ToTable("Users");

            builder.Entity<AdminItem>()
            .ToTable("Admins");
            //.HasOne<AdminItem>()
            //.WithMany()
            //.HasForeignKey(o => o.IdUser)
            //.HasIndex(c => c.IdUser).IsUnique();

            builder.Entity<BuyerItem>()
            .ToTable("Buyers");
            //.HasOne<BuyerItem>()
            //.WithMany()
            //.HasForeignKey(o => o.IdUser);
            //.HasIndex(c => c.IdUser).IsUnique();
        }
    }

  

    public class ServiceContextFactory : IDesignTimeDbContextFactory<ServiceContext>
    {
        public ServiceContext CreateDbContext(string[] args)
        {
            var builder = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json", false, true);
            var config = builder.Build();
            var connectionString = config.GetConnectionString("ServiceContext");
            var optionsBuilder = new DbContextOptionsBuilder<ServiceContext>();
            optionsBuilder.UseSqlServer(config.GetConnectionString("ServiceContext"));

            return new ServiceContext(optionsBuilder.Options);
        }
    }
}