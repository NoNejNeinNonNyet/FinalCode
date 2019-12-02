using System.Collections.Generic;

namespace Entities.BussinessModels
{
    public class CustmerCategoriesModel
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public List<Category> Categories { get; set; }
    }
}
