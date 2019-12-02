using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Maps
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            this.Ignore(t => t.CreatedBy);
            this.Ignore(t => t.CreatedOn);
            this.Ignore(t => t.LastModifiedOn);
            this.Ignore(t => t.LastModifiedBy);

            this.HasKey(t => t.ID);
            this.Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(t => t.CompanyName).HasMaxLength(500).IsRequired();
            this.Property(t => t.ContactName).HasMaxLength(100).IsRequired();
            this.Property(t => t.Address).HasMaxLength(200).IsRequired();
            this.Property(t => t.City).HasMaxLength(100).IsRequired();
            this.Property(t => t.PostalCode).HasMaxLength(50).IsRequired();
            this.Property(t => t.Country).HasMaxLength(100).IsRequired();
            this.Property(t => t.Phone).HasMaxLength(50).IsRequired();

            this.HasMany(e => e.Orders)
            .WithRequired(e => e.Customer)
            .WillCascadeOnDelete(false);

            // this.HasMany(t => t.CustomerMessages).WithRequired(z => z.Customer)
            //   .HasForeignKey(z => z.CustomerID).WillCascadeOnDelete(false);
        }
    }
}
