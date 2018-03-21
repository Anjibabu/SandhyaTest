using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class FireProtectionSystemsController : Controller
    {
        // GET: FireProtectionSystems
        public ActionResult Index()
        {
            Log.Info("Fire Protection Systems Controller Started");
            return View();
        }
    }
}