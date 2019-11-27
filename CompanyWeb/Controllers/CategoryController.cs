using CompanyWeb.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompanyWeb.Extensions;
using CompanyWeb.Helpers;
using System.Web.Helpers;
using Entities.BussinessModels;

namespace CompanyWeb.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            var model = new CategoryViewModel();
            if (id > 0)
            {
                var cat = _categoryService.GetAll(t => t.ID == id).FirstOrDefault();
                //  var cat = _categoryService.GetAll().FirstOrDefault(t => t.ID == id);
                if (cat != null) model = cat.ToCategoryViewModel();
                else
                {
                    throw new Exception("error");
                }
            }

            return View(model);
        }

        [HttpPost]
        public ActionResult AddOrEdit(CategoryViewModel model)
        {
            if (model.ID == 0)
            {
                var id = _categoryService.GetAll().Select(t => t.ID).DefaultIfEmpty().Max() + 1;
                model.ID = id;
                _categoryService.Create(model.ToCategory());
            }
            else
            {
                var cat = _categoryService.GetAll(t => t.ID == model.ID).FirstOrDefault();
                if (cat == null)
                    return Json(new { success = false, message = "Category not exists!" }); //todo

                cat = model.ToCategory(cat);
                // cat.Name = model.Name;
                // cat.Description = model.Description;
                _categoryService.Update(cat);
            }
            return Json(
                new
                {
                    success = true,
                    message = "Successfully Submited!",
                    html = ViewToString.RenderRazorViewToString(this, "ViewAll", GetAllCategories())
                }, JsonRequestBehavior.AllowGet
                );
        }
        public ActionResult ViewAll()
        {
            return View(GetAllCategories());
        }
        private IEnumerable<CategoryViewModel> GetAllCategories()
        {
            return _categoryService.GetAll().Select(t => t.ToCategoryViewModel());
        }
        public ActionResult Delete(int id)
        {
            var category = _categoryService.GetAll(t => t.ID == id).FirstOrDefault();
            if (category != null)
            {
                _categoryService.Delete(category);
            }

            return Json(new
            {
                success = true,
                message = "Successfully Deleted!",
                html = ViewToString.RenderRazorViewToString(this, "ViewAll", GetAllCategories())
            }, JsonRequestBehavior.AllowGet);

        }

        [HttpGet]
        public ActionResult OrdersByCategoryReport(int id = 0)
        {
            //List<OrdersByCategoryModel> model = _categoryService.OrdersByCategoryReport();
            //return View(model);
            return View();
        }

        [HttpPost]
        public JsonResult LoadData()
        {
            //List<OrdersByCategoryModel> model = _categoryService.OrdersByCategoryReport();
            //return View(model);
            //var draw = Request.Form.GetValues("draw").FirstOrDefault();
            var start = Request.Form.GetValues("start").FirstOrDefault();
            var length = Request.Form.GetValues("length").FirstOrDefault();
            //Find Order Column
            var sortColumn = Request.Form.GetValues("columns[" + Request.Form.GetValues("order[0][column]").FirstOrDefault() + "][name]").FirstOrDefault();
            var sortColumnDir = Request.Form.GetValues("order[0][dir]").FirstOrDefault();


            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;

            List<OrdersByCategoryModel> list = _categoryService.OrdersByCategoryReport();

            //SORT
            if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDir)))
            {
                list = list.OrderBy(t => t.OrderDate).ToList();
            }

            recordsTotal = list.Count();
            var data = list.Skip(skip).Take(pageSize).ToList();

            //draw = draw,
            return Json(new { recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data }, JsonRequestBehavior.AllowGet);
        }
    }
}