using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class TypeofConstructionController : Controller
    {
        // GET: TypeofConstruction
        public ActionResult Index()
        {
            Log.Info("Type of Construction Controller Started");

            return View();
        }
    }
}