namespace Repository
{
    using Entities.DbEntities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class Customer: BaseEntity
    {
          public Customer()
        {
            Orders = new HashSet<Order>();
            CustomerMessages = new HashSet<CustomerMessage>();

        }

      //  [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

       // [Required]
       // [StringLength(500)]
        public string CompanyName { get; set; }

        //[Required]
        //[StringLength(100)]
        public string ContactName { get; set; }

       // [Required]
        //[StringLength(200)]
        public string Address { get; set; }

       // [Required]
       // [StringLength(100)]
        public string City { get; set; }

       // [Required]
       // [StringLength(50)]
        public string PostalCode { get; set; }

       // [Required]
       // [StringLength(100)]
        public string Country { get; set; }

      //  [Required]
       // [StringLength(50)]
        public string Phone { get; set; }

 
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<CustomerMessage> CustomerMessages { get; set; }
    }
}
