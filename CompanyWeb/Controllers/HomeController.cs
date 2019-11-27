using CompanyWeb.Helpers;
using Entities.BussinessModels;
using Repository;
using Services.HttpProvider;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompanyWeb.Controllers
{

    public class HomeController : Controller
    {
        private readonly IReportService _reportService;
        private readonly ICategoryService _categoryService;
        private readonly IHttpProvider _httpProvider;

        public HomeController(
            IReportService reportService,
            ICategoryService categoryService,
            IHttpProvider httpProvider
            )
        {
            _reportService = reportService;
            _categoryService = categoryService;
            _httpProvider = httpProvider;
        }

        [MyCustom]
        public ActionResult Index()
        {
            //--Index method in Home Controller started
            var x = _reportService.GetCustomerCategories(1);
            var z = _categoryService.GetAll().ToList();
            //--Index method in Home Controller finished

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public JsonResult TestMethod()
        {
            //CustmerCategoriesModel result = _reportService.GetCustomerCategories(1);
            return Json(new { Name = "Test", ID = 3 }, JsonRequestBehavior.AllowGet);
        }
    }
}