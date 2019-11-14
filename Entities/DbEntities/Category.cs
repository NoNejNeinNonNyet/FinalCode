namespace Repository
{
    using Entities.DbEntities;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class Category: BaseEntity
    {
   
        public Category()
        {
            Products = new HashSet<Product>();
        }

       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        //[Required]
        //[StringLength(500)]
        public string Name { get; set; }

       // [StringLength(500)]
        public string Description { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
}
