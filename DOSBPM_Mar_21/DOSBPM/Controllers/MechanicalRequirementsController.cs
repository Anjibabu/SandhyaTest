using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class MechanicalRequirementsController : Controller
    {
        // GET: MechanicalRequirements
        public ActionResult Index()
        {
            Log.Info("Mechanical Requirements Controller Started");
            return View();
        }
    }
}