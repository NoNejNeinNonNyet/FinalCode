using Entities.BussinessModels;

namespace Services.Interfaces
{
    public interface IReportService
    {
        CustmerCategoriesModel GetCustomerCategories(int customerID);
        CustmerCategoriesModel GetSomething(int customerID);

    }
}
