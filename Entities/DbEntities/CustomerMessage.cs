using Entities.DbEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


public partial class CustomerMessage : BaseEntity
{

    public long ID { get; set; }


    public DateTime Date { get; set; }


    public string Message { get; set; }


    public string Topic { get; set; }

    public int CustomerID { get; set; }

    public virtual Customer Customer { get; set; }
}