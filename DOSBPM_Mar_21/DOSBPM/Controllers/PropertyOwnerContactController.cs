using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOSBPM.Models;
using Newtonsoft.Json;

namespace DOSBPM.Controllers
{
    public class PropertyOwnerContactController : BaseController
    {
        // GET: PropertyOwnerContact

        DEV_CODES_APPDBEntities appdbEntities = new DEV_CODES_APPDBEntities();

        public ActionResult Index()
        {

			BuildingApplication buildApp = new BuildingApplication();
			PropertyOwnerInfo propertyOwnerInfo = new PropertyOwnerInfo();

			if (Session["BuildingApplication"] != null)
			{
				buildApp = (BuildingApplication)Session["BuildingApplication"];
			}
			else
			{
				string jsonData = string.Empty;
				temp_BPMData objtemp_BPMData = db.temp_BPMData.FirstOrDefault(x => x.AppID == "1" && x.UserID == "1");
				if (objtemp_BPMData != null)
				{
					jsonData = objtemp_BPMData.JsonData;
				}
				buildApp = JsonConvert.DeserializeObject<BuildingApplication>(jsonData);
			}
			if (buildApp == null)
			{
				buildApp = new BuildingApplication();
			}

			ViewBag.info = new List<SelectListItem> {
														new SelectListItem {Value="Property Owner Organization", Text="Property Owner Organization", Selected=(buildApp.PropertyOwnerInfoData?.PropertyOwnerType=="Property Owner Organization")},
														new SelectListItem {Value="Property Owner Individual", Text="Property Owner Individual", Selected=(buildApp.PropertyOwnerInfoData?.PropertyOwnerType=="Property Owner Individual")}

													};
			buildApp.PropertyOwnerInfoData = (buildApp.PropertyOwnerInfoData == null) ? new PropertyOwnerInfo() : buildApp.PropertyOwnerInfoData;
			buildApp.PropertyOwnerInfoData.AddressInfo = (buildApp.PropertyOwnerInfoData.AddressInfo == null) ? new AddressInfo() : buildApp.PropertyOwnerInfoData.AddressInfo;

			//  buildApp.PropertyOwnerInfoData = ;
			AddressInfo objAddressInfo = new AddressInfo();
			buildApp.PropertyOwnerInfoData.AddressInfo.CountryList = objAddressInfo.CountryList;
			buildApp.PropertyOwnerInfoData.AddressInfo.StatesList = objAddressInfo.StatesList;
			buildApp.PropertyOwnerInfoData.AddressInfo.CountiesList = objAddressInfo.CountiesList;
			return View(buildApp.PropertyOwnerInfoData);
            

        }
    }
}