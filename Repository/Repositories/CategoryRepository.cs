using Entities.BussinessModels;
using Repository.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public List<OrdersByCategoryModel> OrdersByCategoryReport()
        {
            return DataContext.Database.SqlQuery<OrdersByCategoryModel>("EXECUTE [dbo].[OrderReport]").ToList();
        }
    }
}
