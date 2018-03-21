using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class GeneralBuildingHeightsandAreasController : Controller
    {
        // GET: GeneralBuildingHeightsandAreas
        public ActionResult Index()
        {
            Log.Info("General Building Heights and Areas Controller Started");
            return View();
        }
    }
}