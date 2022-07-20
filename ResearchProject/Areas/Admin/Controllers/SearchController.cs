using Microsoft.AspNetCore.Mvc;
using ResearchProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ResearchProject.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class SearchController : Controller
    {
        private readonly CoffeeShopProjectContext _context;
        public SearchController (CoffeeShopProjectContext context)
        {
            _context = context;
        }
        // GET: Search/FindProduct
        [HttpPost]
        public IActionResult FindProduct(string keyword)
        {
            List<Product> ls = new List<Product>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListProductsSearchPartial",null);
            }
            ls = _context.Products
                .AsNoTracking()
                .Include(a => a.Cat)
                .Where(x => x.ProductName.Contains(keyword))
                .OrderBy(x => x.ProductName)
                .Take(10)
                .ToList();
            if(ls == null)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            else
            {
                return PartialView("ListProductsSearchPartial", ls);
            }

        }
    }
}
