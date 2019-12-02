using System.ComponentModel.DataAnnotations;

namespace CompanyWeb.Models
{
    public class CategoryViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is Required!")]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}