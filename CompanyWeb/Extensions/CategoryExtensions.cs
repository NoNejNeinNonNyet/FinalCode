using CompanyWeb.Models;

namespace CompanyWeb.Extensions
{
    public static class CategoryExtensions
    {
        public static CategoryViewModel ToCategoryViewModel(this Category category)
        {
            return new CategoryViewModel
            {
                ID = category.ID,
                Name = category.Name,
                Description = category.Description

            };
        }
        public static Category ToCategory(this CategoryViewModel model)
        {
            return new Category
            {
                ID = model.ID,
                Name = model.Name,
                Description = model.Description

            };
        }

        public static Category ToCategory(this CategoryViewModel model, Category retCategory)
        {
            retCategory.Name = model.Name;
            retCategory.Description = model.Description;

            return retCategory;
        }
    }
}