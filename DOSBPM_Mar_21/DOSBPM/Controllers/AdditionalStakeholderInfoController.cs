using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class AdditionalStakeholderInfoController : Controller
    {
        // GET: AdditionalStakeholderInfo
        public ActionResult Index()
        {
            Log.Info("Additional Stakeholder Info Controller Started");

            return View();
        }
    }
}