using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ActionFilters.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Secure()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult NonSecure()
        {
            return View();
        }

    }
}