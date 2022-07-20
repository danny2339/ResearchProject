using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ResearchProject.Models;
using ResearchProject.ModelViews;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace ResearchProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CoffeeShopProjectContext _context;

        public HomeController(ILogger<HomeController> logger, CoffeeShopProjectContext context)
        {
            _logger = logger;
            _context = context; 
        }

        public IActionResult Index()
        {
            HomeVM model = new HomeVM();
            var lsproducts = _context.Products
                .AsNoTracking()
                .Where(x => x.HomeFlag==true)
                .OrderBy(x => x.ProductId)
                .ToList();

            List<ProductHomeVM> lsProductViews = new List<ProductHomeVM>();
            var lsCat = _context.Categories
                .AsNoTracking()
                .Where(x => x.Published == true)
                .OrderBy(x => x.CatId)
                .ToList();
            foreach(var item in lsCat)
            {
                ProductHomeVM productHome = new ProductHomeVM();
                productHome.category = item;
                productHome.lsProducts = lsproducts.Where(x => x.CatId == item.CatId).ToList();
                lsProductViews.Add(productHome);
            }
            var news = _context.News
                .AsNoTracking()
                .Where(x => x.Published == true && x.IsNewfeed == true)
                .Take(3)
                .ToList();
            model.Products = lsProductViews;
            model.News = news;
            ViewBag.Allproduct = lsproducts;
            return View(model);
        }
        [Route("contact.html", Name ="Contact")]
        public IActionResult Contact()
        {
            HomeVM model = new HomeVM();
            var lsproducts = _context.Products
                .AsNoTracking()
                .Where(x=>x.Active==true)
                .OrderBy(x => x.ProductId)
                .ToList();

            List<ProductHomeVM> lsProductViews = new List<ProductHomeVM>();
            var lsCat = _context.Categories
                .AsNoTracking()
                .Where(x => x.Published == true)
                .OrderBy(x => x.CatId)
                .ToList();
            foreach (var item in lsCat)
            {
                ProductHomeVM productHome = new ProductHomeVM();
                productHome.category = item;
                productHome.lsProducts = lsproducts.Where(x => x.CatId == item.CatId).ToList();
                lsProductViews.Add(productHome);
            }
           
            model.Products = lsProductViews;
            return View(model);
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public JsonResult SearchProduct(string term)
        {
           var ls = _context.Products
                .AsNoTracking()
                .Where(x => x.ProductName.Contains(term))
                .Select(x =>x.ProductName).ToList();

            return Json(ls);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
