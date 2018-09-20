using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Work_Personal_Project.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        private const int NotFoundCode = 404;
        private const int InternalErrorCode = 500;

        public ActionResult NotFound()
        {
            Response.StatusCode = NotFoundCode;

            return View();
        }

        public ActionResult InternalError()
        {
            Response.StatusCode = InternalErrorCode;

            return View();
        }
    }
}