using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1Quick1.Web.Controllers {
    public class BlogController : Controller {
        // GET: Blog
        public ActionResult BlogFull() {
            return View();
        }
        public ActionResult BlogLeftSidebar() {
            return View();
        }
        public ActionResult BlogRightSidebar() {
            return View();
        }
        public ActionResult BlogOther() {
            return View();
        }
        public ActionResult BlogSingle() {
            return View();
        }


    }
}