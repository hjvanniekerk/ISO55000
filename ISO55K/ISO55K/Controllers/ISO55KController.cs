using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISO55K.Controllers
{
    public class ISO55KController : Controller
    {
        // GET: ISO55K
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RFI()
        {
            return View();
        }
    }
}