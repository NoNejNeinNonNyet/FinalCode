using System.Data.Entity.ModelConfiguration;

namespace Repository.Maps
{
    public class OrderDetailMap : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMap()
        {
            this.Ignore(t => t.CreatedBy);
            this.Ignore(t => t.CreatedOn);
            this.Ignore(t => t.LastModifiedOn);
            this.Ignore(t => t.LastModifiedBy);

            HasKey(t => new { t.OrderID, t.ProductID });

            Property(e => e.UnitPrice)
             .HasPrecision(19, 2);

            Property(e => e.Discount)
                .HasPrecision(19, 2);
        }
    }
}
