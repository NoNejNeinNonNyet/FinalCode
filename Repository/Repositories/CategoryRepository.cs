using Entities.BussinessModels;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public List<OrdersByCategoryModel> OrdersByCategoryReport()
        {
            return DataContext.Database.SqlQuery<OrdersByCategoryModel>("EXECUTE [dbo].[OrdersByCategoryReport]").ToList();
        }
    }
}
