using DOSBPM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Controllers
{
    public class AdditionalStakeholderContactsController : BaseController
    {
        // GET: AdditionalStakeholderContacts
        DEV_CODES_APPDBEntities appdbEntities = new DEV_CODES_APPDBEntities();


        public ActionResult Index()
        {
            Log.Info("Building Info Controller Started");
            var objList = new PropertyOwnerInfo();
            objList.StatesList = GetStates();
            objList.CountryList = GetCountries();

            objList.CountiesList = GetCounties();

            return View(objList);
        }
    }
}