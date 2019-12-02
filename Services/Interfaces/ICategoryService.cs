using Entities.BussinessModels;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface ICategoryService : IService<Category>
    {
        List<OrdersByCategoryModel> OrdersByCategoryReport();
    }
}