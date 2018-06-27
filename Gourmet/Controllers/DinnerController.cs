using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gourmet.Controllers
{
    public class DinnerController : Controller
    {
        // GET: Dinner
        public ActionResult Dinner()
        {
            return View();
        }
    }
}