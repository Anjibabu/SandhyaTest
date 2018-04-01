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
			PropertyOwnerContactInfo propertyOwnerInfo = new PropertyOwnerContactInfo();

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
			buildApp.PropertyOwnerContactData = (buildApp.PropertyOwnerContactData == null) ? new PropertyOwnerContactInfo() : buildApp.PropertyOwnerContactData;
			buildApp.PropertyOwnerContactData.AddressInfo = (buildApp.PropertyOwnerContactData.AddressInfo == null) ? new AddressInfo() : buildApp.PropertyOwnerContactData.AddressInfo;

			//  buildApp.PropertyOwnerInfoData = ;
			AddressInfo objAddressInfo = new AddressInfo();
			buildApp.PropertyOwnerContactData.AddressInfo.CountryList = objAddressInfo.CountryList;
			buildApp.PropertyOwnerContactData.AddressInfo.StatesList = objAddressInfo.StatesList;
			buildApp.PropertyOwnerContactData.AddressInfo.CountiesList = objAddressInfo.CountiesList;
			buildApp.PropertyOwnerContactData.PropertyOwner = buildApp.PropertyOwnerInfoData.OrganizationName;

			return View(buildApp.PropertyOwnerContactData);
            

        }
    }
}