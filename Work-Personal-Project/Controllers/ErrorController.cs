using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Work_Personal_Project.Controllers
{
    public class ErrorController : Controller
    {       
        // GET errors
        public ActionResult Index()
        {
            var errorCode = Response.StatusCode;

            if (errorCode == 404)
            {
                ViewBag.Title = "Error 404: File Not Found";
                ViewBag.Message = MvcHtmlString.Create("Three things cannot long be hidden:<br />" +
                    "the sun, the moon, and bad code");
                return View();
            } else if (errorCode == 500)
            {
                ViewBag.Title = "Error 500: Internal Server Error";
                ViewBag.Message = "There was an internal server error. Our bad.";
                return View();
            } else
            {
                return View();
            }
            
        }
    }
}