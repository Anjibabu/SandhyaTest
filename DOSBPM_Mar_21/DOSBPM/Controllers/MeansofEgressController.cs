using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class MeansofEgressController : Controller
    {
        // GET: MeansofEgress
        public ActionResult Index()
        {
            Log.Info("Means of Egress Controller Started");
            return View();
        }
    }
}