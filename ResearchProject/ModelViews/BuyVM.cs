using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResearchProject.ModelViews
{
    public class BuyVM
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Please Enter Your Full Name")]
        public string FullName { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Address")]
        public string Address { get; set; }
        
        public string Note { get; set; }
    }
}
