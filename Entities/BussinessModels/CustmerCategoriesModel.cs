using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.BussinessModels
{
   public class CustmerCategoriesModel
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public List<Category> Categories { get; set; }
    }
}
