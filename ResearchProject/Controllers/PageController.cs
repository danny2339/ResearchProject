using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList.Core;
using ResearchProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ResearchProject.Controllers
{
    public class PageController : Controller
    {
        private readonly CoffeeShopProjectContext _context;
        public PageController(CoffeeShopProjectContext context)
        {
            _context = context;
        }
       
        [Route("/page/{Alias}", Name = "PageDetails")]
        public IActionResult Details(string Alias)
        {
            var lscategory = _context.Categories
                    .AsNoTracking()
                    .Where(x => x.Published == true)
                    .OrderBy(x => x.CatId)
                    .ToList();
            ViewBag.lscat = lscategory;
            if (string.IsNullOrEmpty(Alias)) return RedirectToAction("Index", "Home");
            var page = _context.Pages.AsNoTracking().SingleOrDefault(x => x.Alias == Alias);
            if (page == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(page);
        }
    }
}
