namespace Repository
{
    using Repository.Maps;
    using System.Data.Entity;

    public partial class CompanyDB : DbContext
    {
        public CompanyDB()
            : base("name=CompanyDB")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<CustomerMessage> CustomerMessages { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new OrderDetailMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ShipperMap());
            modelBuilder.Configurations.Add(new SupplierMap());
            modelBuilder.Configurations.Add(new CustomerMessageMap());
        }
    }
}
