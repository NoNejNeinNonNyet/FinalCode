using Entities.BussinessModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IReportService
    {
        CustmerCategoriesModel GetCustomerCategories(int customerID);

        CustmerCategoriesModel GetSomething(int customerID);

    }
}
