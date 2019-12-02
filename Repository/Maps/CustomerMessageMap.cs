using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Maps
{
    public class CustomerMessageMap : EntityTypeConfiguration<CustomerMessage>
    {
        public CustomerMessageMap()
        {
            this.Ignore(t => t.CreatedBy);
            this.Ignore(t => t.CreatedOn);
            this.Ignore(t => t.LastModifiedOn);
            this.Ignore(t => t.LastModifiedBy);

            this.HasKey(t => t.ID);
            this.Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(t => t.Message).HasMaxLength(500).IsRequired();
            this.Property(t => t.Topic).HasMaxLength(200).IsRequired();

            this.HasRequired(t => t.Customer).WithMany(z => z.CustomerMessages)
                .HasForeignKey(t => t.CustomerID).WillCascadeOnDelete(false);

        }
    }
}
