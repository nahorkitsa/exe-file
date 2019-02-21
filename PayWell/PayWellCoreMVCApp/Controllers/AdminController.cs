using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PayWellCoreMVCApp.Controllers
{
    [Route("Administrator")]
    public class AdminController : Controller
    {
        [Route("Index")]
        public String Index()
        {
            return "This is Admin index";
        }

        [Route("Product")]
        public string AddProduct()
        {
            return "This is Admin Add Product Home Page";
        }
    }
}