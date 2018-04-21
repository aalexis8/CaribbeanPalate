using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaribbeanPalate.Data;
using CaribbeanPalate.Models;
using CaribbeanPalate.Models.SubCategoryViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CaribbeanPalate.Controllers
{
    public class SubCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Action
        public async Task<IActionResult> Index()
        {
            // Using eager loading we will get categories and subcategories
            var subCategories = _context.SubCategories.Include(s =>s.Category);
            return View(await subCategories.ToListAsync());
        }


        // GET Action for create
        public IActionResult Create()
        {
            SubCategoryAndCategoryViewModel model = new SubCategoryAndCategoryViewModel()
            {
                CategoryList = _context.Categories.ToList(),
                SubCategory = new SubCategory(),
                SubCategoryList = _context.SubCategories.OrderBy(p=>p.Name).Select(p=>p.Name).ToList()
            };

            return View(model);
        }
    }
}