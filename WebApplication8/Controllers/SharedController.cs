using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication8.Controllers
{
    public class SharedController : Controller
    {
        // GET: Shared
        public ActionResult _layout()
        {
            return View();
        }
    }
}