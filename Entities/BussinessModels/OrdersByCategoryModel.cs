using System;

namespace Entities.BussinessModels
{
    public class OrdersByCategoryModel
    {
        public long OrderID { get; set; }
        public string ProductName { get; set; }
        public decimal OrderUnitPrice { get; set; }
        public long OrderQuantity { get; set; }
        public decimal FullPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public string ShipTo { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipperName { get; set; }
    }
}
