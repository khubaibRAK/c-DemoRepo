using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page edited from github.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult ContactAgain()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ContactAgain10()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ContactAgain2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
