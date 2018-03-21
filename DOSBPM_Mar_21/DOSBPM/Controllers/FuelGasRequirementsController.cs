using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class FuelGasRequirementsController : Controller
    {
        // GET: FuelGasRequirements
        public ActionResult Index()
        {
            Log.Info("Fuel Gas Requirements Controller Started");
            return View();
        }
    }
}