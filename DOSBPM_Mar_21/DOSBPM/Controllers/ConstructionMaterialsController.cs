using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class ConstructionMaterialsController : Controller
    {
        // GET: ConstructionMaterials
        public ActionResult Index()
        {
            Log.Info("Construction Materials Controller Started");

            return View();
        }
    }
}