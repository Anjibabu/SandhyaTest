using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class SafeguardsDuringConstructionController : Controller
    {
        // GET: SafeguardsDuringConstruction
        public ActionResult Index()
        {
            Log.Info("Safeguards During Construction Controller Started");

            return View();
        }
    }
}