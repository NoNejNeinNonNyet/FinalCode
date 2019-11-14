namespace Repository
{
    using Entities.DbEntities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Supplier: BaseEntity
    {
 
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

       // [Required]
      //  [StringLength(500)]
        public string Name { get; set; }

        //[Required]
        //[StringLength(500)]
        public string ContactPersonName { get; set; }

       // [Required]
       // [StringLength(200)]
        public string Address { get; set; }

        //[Required]
        //[StringLength(50)]
        public string PostalCode { get; set; }

       // [Required]
        //[StringLength(100)]
        public string City { get; set; }

       // [Required]
       // [StringLength(100)]
        public string Country { get; set; }

       // [Required]
       // [StringLength(50)]
        public string Phone { get; set; }

        //[StringLength(500)]
        public string HomePage { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
}
