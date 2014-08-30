using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemersSolutions.web.Controllers {
    public class UIElementsController : Controller {
        // GET: UIElements
        public ActionResult CSS() {
            return View();
        }
        public ActionResult Components() {
            return View();
        }
        public ActionResult AdditionalComponents() {
            return View();
        }
        public ActionResult Layout() {
            return View();
        }



    }
}