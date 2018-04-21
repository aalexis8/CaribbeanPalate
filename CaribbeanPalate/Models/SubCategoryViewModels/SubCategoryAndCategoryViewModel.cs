using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CaribbeanPalate.Models.SubCategoryViewModels
{
    public class SubCategoryAndCategoryViewModel
    {
        public SubCategory SubCategory { get; set; }

        // To display available categories to the user in the view
        public IEnumerable<Category> CategoryList { get; set; }

        // A list of sub category
        public List<string> SubCategoryList { get; set; }

        [Display(Name ="New Sub Category")]
        public bool isNew { get; set; }

        // Display Error Messages to user
        public string StatusMessage { get; set; }
    }
}
