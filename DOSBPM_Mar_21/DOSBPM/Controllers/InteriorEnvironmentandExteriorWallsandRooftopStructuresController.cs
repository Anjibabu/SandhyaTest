using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class InteriorEnvironmentandExteriorWallsandRooftopStructuresController : Controller
    {
        // GET: InteriorEnvironmentandExteriorWallsandRooftopStructures
        public ActionResult Index()
        {
            Log.Info("Interior Environment and Exterior Walls and Rooftop Structures Controller Started");

            return View();
        }
    }
}