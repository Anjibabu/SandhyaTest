using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class OccupancyHeightsandAreasController : Controller
    {
        // GET: OccupancyHeightsandAreas
        public ActionResult Index()
        {
            Log.Info("Occupancy Heights and Areas Controller Started");

            return View();
        }
    }
}