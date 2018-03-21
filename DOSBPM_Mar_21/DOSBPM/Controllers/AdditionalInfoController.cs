using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class AdditionalInfoController : Controller
    {
        // GET: AdditionalInfo
        public ActionResult Index()
        {
            Log.Info("AdditionalInfo Controller Started");
            return View();
        }
    }
}