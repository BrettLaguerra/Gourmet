using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gourmet.Controllers
{
    public class LunchController : Controller
    {
        // GET: Lunch
        public ActionResult Lunch()
        {
            return View();
        }
    }
}