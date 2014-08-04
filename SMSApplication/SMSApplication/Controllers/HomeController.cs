using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {//Change 1 in Branch1
            //Additional Changes
        //Change 2 in Branch2
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}