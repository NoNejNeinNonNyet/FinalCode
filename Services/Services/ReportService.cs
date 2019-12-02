using Entities.BussinessModels;
using Repository.Interfaces;
using Services.Interfaces;
using System.Linq;

namespace Services.Services
{
    public class ReportService : IReportService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ICustomerRepository _customerRepository;
        public ReportService(ICategoryRepository categoryRepository, ICustomerRepository customerRepository)
        {
            _categoryRepository = categoryRepository;
            _customerRepository = customerRepository;
        }

        public CustmerCategoriesModel GetCustomerCategories(int customerID)
        {
            var categories = _categoryRepository.All().ToList();
            var customer = _customerRepository.All(t => t.ID == customerID).FirstOrDefault();

            if (customer == null) return null;

            var model = new CustmerCategoriesModel
            {
                CustomerID = customer.ID,
                CustomerName = customer.ContactName,
                Categories = categories
            };

            return model;
        }

        public CustmerCategoriesModel GetSomething(int customerID)
        {
            //var model = new CustmerCategoriesModel
            //{
            //    CustomerID = 1,
            //    CustomerName = "SEDC"
            //};

            var categories = _categoryRepository.All().ToList();
            var customer = _customerRepository.All(t => t.ID == customerID).FirstOrDefault();

            if (customer == null) return null;

            var model = new CustmerCategoriesModel
            {
                CustomerID = customer.ID,
                CustomerName = customer.ContactName,
                Categories = categories
            };

            return model;
        }

    }
}
