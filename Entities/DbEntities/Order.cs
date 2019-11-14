using Entities.DbEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class Order : BaseEntity
{

    public Order()
    {
        OrderDetails = new HashSet<OrderDetail>();
    }

    public long ID { get; set; }

    public int ShipperID { get; set; }

    public int CustomerID { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    // [Required]
    // [StringLength(500)]
    public string ShipName { get; set; }

    //[Required]
    // [StringLength(200)]
    public string ShipAddress { get; set; }

    // [Required]
    // [StringLength(100)]
    public string ShipCity { get; set; }

    //[Required]
    //[StringLength(50)]
    public string ShipPostalCode { get; set; }

    //[Required]
    //[StringLength(100)]
    public string ShipCountry { get; set; }

    public virtual Customer Customer { get; set; }


    public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    public virtual Shipper Shipper { get; set; }
}