using Services.Interfaces;
using System.Linq;
using System.Web.Mvc;

namespace CompanyWeb.Helpers
{
    public class MyCustomAttribute : ActionFilterAttribute
    {
        public ICategoryService CategoryService { get; set; }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //todo logic
            var c = CategoryService.GetAll().ToList();
            base.OnActionExecuting(filterContext);
        }
    }
}