using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOSBPM.Models;

namespace DOSBPM.Controllers
{
    public class AdditionalStakeholderIndividualInfoController : BaseController
    {
        // GET: AdditionalStakeholderIndividualInfo
        DEV_CODES_APPDBEntities appdbEntities = new DEV_CODES_APPDBEntities();


        public ActionResult Index()
        {
            Log.Info("Building Info Controller Started");

            var objList = new PropertyOwnerInfo();

            return View(objList);
        }
    }
}