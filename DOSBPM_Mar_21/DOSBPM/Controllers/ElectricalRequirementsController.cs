using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class ElectricalRequirementsController : Controller
    {
        // GET: ElectricalRequirements
        public ActionResult Index()
        {
            Log.Info("Electrical Requirements Controller Started"); 

            return View();
        }
    }
}