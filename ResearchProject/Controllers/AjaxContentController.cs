using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchProject.Controllers
{
    public class AjaxContentController : Controller
    {
        public IActionResult NumberCart()
        {
            return ViewComponent("NumberCart");
        }
    }
}
