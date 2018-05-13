using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reminizent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content("This is the home page");
        }
    }
}