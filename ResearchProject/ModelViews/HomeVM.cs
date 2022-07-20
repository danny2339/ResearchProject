using ResearchProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchProject.ModelViews
{
    public class HomeVM
    {
        public List<News> News { get; set; }
        public List<ProductHomeVM> Products { get; set; }
    }
}
