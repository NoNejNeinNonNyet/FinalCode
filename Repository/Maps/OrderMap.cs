using System.Data.Entity.ModelConfiguration;

namespace Repository.Maps
{
    public class OrderMap : EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            this.Ignore(t => t.CreatedBy);
            this.Ignore(t => t.CreatedOn);
            this.Ignore(t => t.LastModifiedOn);
            this.Ignore(t => t.LastModifiedBy);

            this.HasKey(t => t.ID);
            this.Property(t => t.ShipName).HasMaxLength(500).IsRequired();
            this.Property(t => t.ShipAddress).HasMaxLength(200).IsRequired();
            this.Property(t => t.ShipCity).HasMaxLength(100).IsRequired();
            this.Property(t => t.ShipPostalCode).HasMaxLength(50).IsRequired();
            this.Property(t => t.ShipCountry).HasMaxLength(100).IsRequired();
            HasMany(e => e.OrderDetails)
              .WithRequired(e => e.Order)
              .WillCascadeOnDelete(false);
        }
    }
}
