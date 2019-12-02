using System.Data.Entity.ModelConfiguration;

namespace Repository.Maps
{
    public class ShipperMap : EntityTypeConfiguration<Shipper>
    {
        public ShipperMap()
        {
            this.Ignore(t => t.CreatedBy);
            this.Ignore(t => t.CreatedOn);
            this.Ignore(t => t.LastModifiedOn);
            this.Ignore(t => t.LastModifiedBy);

            this.HasKey(t => t.ID);
            this.Property(t => t.CompanyName).IsRequired().HasMaxLength(100);
            this.Property(t => t.Phone).IsRequired().HasMaxLength(50);
            HasMany(e => e.Orders)
               .WithRequired(e => e.Shipper)
               .WillCascadeOnDelete(false);
        }
    }
}
