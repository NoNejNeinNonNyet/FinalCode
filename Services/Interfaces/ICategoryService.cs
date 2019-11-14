using Entities.BussinessModels;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICategoryService:IService<Category> 
    {
        List<OrdersByCategoryModel> OrdersByCategoryReport();
    }
}
