using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class SoilsandFoundationsController : Controller
    {
        // GET: SoilsandFoundations
        public ActionResult Index()
        {
            Log.Info("Soils and Foundations Controller Started");
            return View();
        }
    }
}