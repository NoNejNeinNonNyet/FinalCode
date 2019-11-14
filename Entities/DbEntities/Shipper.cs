namespace Repository
{
    using Entities.DbEntities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class Shipper: BaseEntity
    {
         public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

       // [Required]
       // [StringLength(500)]
        public string CompanyName { get; set; }

       // [Required]
       // [StringLength(50)]
        public string Phone { get; set; }

       
        public virtual ICollection<Order> Orders { get; set; }
    }
}
