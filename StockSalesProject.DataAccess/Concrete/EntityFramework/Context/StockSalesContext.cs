using StockSalesProject.Entity.Concrete;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace StockSalesProject.DataAccess.Concrete.EntityFramework.Context
{
    public class StockSalesContext : DbContext
    {
        public StockSalesContext()
        {
            Database.Connection.ConnectionString = "Server=DESKTOP-QR4J7JA\\SQLEXPRESS;Database=StockSalesDb;Trusted_Connection=True;";
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Storeroom> Storerooms { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EmployeeAndRole> EmployeeAndRoles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>().Ignore(x => x.OrderProductId);
            modelBuilder.Entity<OrderProduct>().HasKey(x => new { x.OrderId, x.ProductId });

            //modelBuilder.Entity<Storeroom>().HasRequired<Company>(s => s.Company).WithMany(c => c.Storerooms).HasForeignKey(s => s.CompanyId);

            modelBuilder.Entity<EmployeeAndRole>().HasKey(x => new { x.EmployeeId, x.RoleId });

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }
    }
}