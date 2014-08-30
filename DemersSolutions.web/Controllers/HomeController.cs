using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1Quick1.Web.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View("Index");
        }

        public ActionResult Index2() {
            return View("Index2");
        }

    }
}