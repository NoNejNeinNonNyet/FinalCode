using Entities.DbEntities;
using System;


public partial class CustomerMessage : BaseEntity
{

    public long ID { get; set; }


    public DateTime Date { get; set; }


    public string Message { get; set; }


    public string Topic { get; set; }

    public int CustomerID { get; set; }

    public virtual Customer Customer { get; set; }
}