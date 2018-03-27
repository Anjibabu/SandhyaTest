using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Models
{
	public class AddressInfo
	{
		DEV_CODES_APPDBEntities appdbEntities = new DEV_CODES_APPDBEntities();
		public string AddressId { get; set; }
		public string StkHoldTypeId { get; set; }
		public string StkHoldTypeName { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string City { get; set; }
		public string StateName { get; set; }
		public string CountryName { get; set; }
		public int Zip { get; set; }
		public int Zip4Format { get; set; }
		public string CountyId { get; set; }
		public string StateId { get; set; }
		public string CountryId { get; set; }
		public string TelephoneNumber { get; set; }
		public string EmailId { get; set; }

		public SelectList CountryList
		{
			get
			{
				return new SelectList(appdbEntities.L_Country, "Country_ID", "Country_Name");
			}
		}
		public SelectList StatesList
		{
			get
			{
				return new SelectList(appdbEntities.L_State, "State_ID", "State_Name");
			}
		}
		public SelectList CountiesList
		{
			get
			{
				return new SelectList(appdbEntities.L_County, "County_ID", "County_Name");
			}
		}
	}
}