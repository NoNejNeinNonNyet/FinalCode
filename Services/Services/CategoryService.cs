using Entities.BussinessModels;
using Repository.Interfaces;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services.Services
{
    public class CategoryService : Service<Category, ICategoryRepository>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public override ICategoryRepository Repository
        {
            get; protected set;
        }
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            Repository = _categoryRepository;
        }

        public List<OrdersByCategoryModel> OrdersByCategoryReport()
        {
            return _categoryRepository.OrdersByCategoryReport();
        }
    }
}
