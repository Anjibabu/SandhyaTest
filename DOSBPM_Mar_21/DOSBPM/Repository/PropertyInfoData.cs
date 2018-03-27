using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOSBPM.Models;

namespace DOSBPM.Repository
{
	public class PropertyInfoData
	{
		DEV_CODES_APPDBEntities db = null;
		public PropertyInfoData()
		{
			db = new DEV_CODES_APPDBEntities();
		}
		public List<IndividualInformation> GetPropertyIndividualInfoData(string searchStr)
		{
			var data = db.usp_getstackHolderInfo(searchStr, "Ind").ToList() ;
			List<IndividualInformation> result = (from sh in data
												  select new IndividualInformation
												  {
													  StkHoldTypeId = sh.StkHoldType_ID,
													  StkHoldTypeName = sh.StkHoldType_Name,
													  FirstName = sh.IndiInfo_FirstName,
													  LastName = sh.IndiInfo_LastName,
													  AddressId = sh.Address_ID,
													  Address1 = sh.Address_1,
													  Address2 = sh.Address_2,
													  City = sh.City,
													  StateName = sh.StateName,
													  CountryName = sh.CountryName,
													  Zip = sh.ZIP,
													  CountyId = sh.County_ID,
													  StateId = sh.State_ID,
													  CountryId = sh.Country_ID,
													  TelephoneNumber = sh.ContAdd_TelephoneNumber,
													  EmailId = sh.ContAdd_EmailID
												  }).ToList();
		 

			return result;

		}
	}
}
