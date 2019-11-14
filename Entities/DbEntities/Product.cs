namespace Repository
{
    using Entities.DbEntities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class Product: BaseEntity
    {
     public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
       
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID { get; set; }

        //[Required]
       // [StringLength(500)]
        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        public long UnitInStock { get; set; }

        public long UnitsOnOrder { get; set; }

        public int CategoryID { get; set; }

        public int SupplierID { get; set; }

        public virtual Category Category { get; set; }

     
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public virtual Supplier Supplier { get; set; }
    }
}
