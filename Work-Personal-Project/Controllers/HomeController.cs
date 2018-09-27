using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Work_Personal_Project.Static;

namespace Work_Personal_Project.Controllers
{
    public class HomeController : Controller
    {
        [Compress]
        public ActionResult Index()
        {
            return View();
        }

        [Compress]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Compress]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Compress]
        public ActionResult Resume()
        {
            ViewBag.Message = "Your resume.";

            return View();
        }

        [Compress]
        public ActionResult Portfolio()
        {
            ViewBag.Message = "Your portfolio.";

            return View();
        }
    }
}