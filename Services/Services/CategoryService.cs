using Entities.BussinessModels;
using Repository;
using Repository.Interfaces;
using Repository.Repositories;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
   public class CategoryService:Service<Category,ICategoryRepository>,ICategoryService
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
