using Entities.BussinessModels;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<OrdersByCategoryModel> OrdersByCategoryReport();
    }
}
