using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class SpecialDetailedRequirementsBasedonUseandOccupancyController : Controller
    {
        // GET: SpecialDetailedRequirementsBasedonUseandOccupancy
        public ActionResult Index()
        {
            Log.Info("Special Detailed Requirements Based on Use and Occupancy Controller Started");

            return View();
        }
    }
}