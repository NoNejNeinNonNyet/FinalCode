using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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