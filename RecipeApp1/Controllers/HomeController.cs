using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RecipeApp1.Models;

namespace RecipeApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult About()
        {    
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}