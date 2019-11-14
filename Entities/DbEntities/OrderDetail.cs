using Entities.DbEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class OrderDetail : BaseEntity
{
    //[Key]
    //[Column(Order = 0)]
    //[DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long OrderID { get; set; }

    //[Key]
    //[Column(Order = 1)]
    //[DatabaseGenerated(DatabaseGeneratedOption.None)]
    public long ProductID { get; set; }

    public decimal UnitPrice { get; set; }

    public long Quantity { get; set; }

    public decimal? Discount { get; set; }

    public virtual Order Order { get; set; }

    public virtual Product Product { get; set; }
}