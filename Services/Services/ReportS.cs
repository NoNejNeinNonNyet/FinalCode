using Entities.BussinessModels;
using Repository.Interfaces;
using Services.Interfaces;
using System;

namespace Services.Services
{
    public class ReportS : IReportService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICustomerRepository _customerRepository;
        public ReportS(ICategoryRepository categoryRepository, ICustomerRepository customerRepository)
        {
            _categoryRepository = categoryRepository;
            _customerRepository = customerRepository;
        }

        public CustmerCategoriesModel GetCustomerCategories(int customerID)
        {


            var model = new CustmerCategoriesModel
            {
                CustomerID = 0,
                CustomerName = "noname",
                Categories = null
            };

            return model;
        }

        public CustmerCategoriesModel GetSomething(int customerID)
        {
            throw new NotImplementedException();
        }
    }
}
