using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Maps
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            this.Ignore(t => t.CreatedBy);
            this.Ignore(t => t.CreatedOn);
            this.Ignore(t => t.LastModifiedOn);
            this.Ignore(t => t.LastModifiedBy);

            this.HasKey(t => t.ID);
            this.Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(e => e.UnitPrice).HasPrecision(19, 2);
            this.Property(t => t.Name).IsRequired().HasMaxLength(500);

            Property(e => e.Name).HasColumnName("Name");  // no need if name is same in class and db

            HasMany(e => e.OrderDetails)
            .WithRequired(e => e.Product)
            .WillCascadeOnDelete(false);

            // same with relation on CategoryMap
            //this.HasRequired(t => t.Category).WithMany(t => t.Products).WillCascadeOnDelete(false);
        }
    }
}
