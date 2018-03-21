using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOSBPM.Models;
namespace DOSBPM.Controllers
{
    public class BuildingInfoController : BaseController
    {
        // GET: BuildingInfo
        DEV_CODES_APPDBEntities appdbEntities = new DEV_CODES_APPDBEntities();


        public ActionResult Index()
        {
            Log.Info("Building Info Controller Started test1");
            var objList = new PropertyOwnerInfo();
            objList.StatesList = GetStates();
            objList.CountryList = GetCountries();

            objList.CountiesList = GetCounties();

            return View(objList);
        }
    }
}