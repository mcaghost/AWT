using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerApplication_MVC.Models
{
    public class Customer
    {
        [Required(ErrorMessage = "Please enter Customer Id..!")]
        public int Custid { get;set; }
        [Required(ErrorMessage = "Please enter Customer Name..!")]
        public string CustName { get; set; }
        [Required(ErrorMessage = "Please enter Customer Address..!")]
        public string CustAdd { get; set; }

        
    }
}