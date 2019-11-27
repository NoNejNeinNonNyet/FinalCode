using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Maps
{
    public class SupplierMap : EntityTypeConfiguration<Supplier>
    {
        public SupplierMap()
        {
            this.Ignore(t => t.CreatedBy);
            this.Ignore(t => t.CreatedOn);
            this.Ignore(t => t.LastModifiedOn);
            this.Ignore(t => t.LastModifiedBy);

            this.HasKey(t => t.ID);
            this.Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.HomePage).HasMaxLength(500);
            this.Property(t => t.Name).IsRequired().HasMaxLength(500);
            this.Property(t => t.ContactPersonName).IsRequired().HasMaxLength(500);
            this.Property(t => t.Address).IsRequired().HasMaxLength(200);
            this.Property(t => t.PostalCode).IsRequired().HasMaxLength(50);
            this.Property(t => t.Country).IsRequired().HasMaxLength(100);
            this.Property(t => t.City).IsRequired().HasMaxLength(100);
            this.Property(t => t.Phone).IsRequired().HasMaxLength(50);

            HasMany(e => e.Products)
              .WithRequired(e => e.Supplier)
              .WillCascadeOnDelete(false);
        }
    }
}
