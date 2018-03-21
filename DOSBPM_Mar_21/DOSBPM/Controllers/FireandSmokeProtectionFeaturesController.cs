using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class FireandSmokeProtectionFeaturesController : Controller
    {
        // GET: FireandSmokeProtectionFeatures
        public ActionResult Index()
        {
            Log.Info("Fire and Smoke Protection Features Controller Started");
            return View();
        }
    }
}