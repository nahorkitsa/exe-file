using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayWellCoreMVCApp.Models;

namespace PayWellCoreMVCApp.Controllers
{
    
    public class HomeController : Controller
    {
       
        public String Index(string id)
        {
            if (id == null)
            {
                return "Home Index :Hello...!!Your First MVC App";
            }
            return "HomeController :Index : id =" +id;
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
