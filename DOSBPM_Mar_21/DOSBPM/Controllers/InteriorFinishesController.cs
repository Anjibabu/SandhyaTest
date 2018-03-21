using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class InteriorFinishesController : Controller
    {
        // GET: InteriorFinishes
        public ActionResult Index()
        {
            Log.Info("Interior Finishes Controller Started");
            return View();
        }
    }
}