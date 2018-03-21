using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class EnergyRequirementsController : Controller
    {
        // GET: EnergyRequirements
        public ActionResult Index()
        {
            Log.Info("Energy Requirements Controller Started");
            return View();
        }
    }
}