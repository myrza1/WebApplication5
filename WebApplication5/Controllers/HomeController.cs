using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Picsel = "Kom";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. This is new pages";
            
            return View();
        }
    }
}