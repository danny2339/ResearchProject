using Microsoft.AspNetCore.Mvc;
using ResearchProject.Extension;
using ResearchProject.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchProject.Controllers.Component
{
    public class NumberCartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("ShoppingCart");
            return View(cart);
        }
    }
}
