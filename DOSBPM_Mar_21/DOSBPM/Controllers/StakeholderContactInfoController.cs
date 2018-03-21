using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class StakeholderContactInfoController : Controller
    {
        // GET: StakeholderContactInfo
        public ActionResult Index()
        {
            Log.Info("Stakeholder Contact Info Controller Started");


            return View();
        }
    }
}