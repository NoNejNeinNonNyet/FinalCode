using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Repository.Maps
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            this.Ignore(t => t.CreatedBy);
            this.Ignore(t => t.CreatedOn);
            this.Ignore(t => t.LastModifiedOn);
            this.Ignore(t => t.LastModifiedBy);

            this.HasKey(t => t.ID);
            this.Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Name).IsRequired();
            this.Property(t => t.Name).HasMaxLength(500);

            this.Property(t => t.Description).HasMaxLength(500);

            this.HasMany(e => e.Products)
              .WithRequired(e => e.Category)
              .WillCascadeOnDelete(false);
        }
    }
}
