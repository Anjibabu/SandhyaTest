using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSBPM.Models
{
	public class PropertyOwnerContactInfo : IBuildingInfo
	{
		public string PropertyOwnerType { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public string Suffix { get; set; }
		public string TelePhoneNumber { get; set; }
		public string EmailID { get; set; }
		public string Comments { get; set; }
		public string TransType { get; set; }
		public string Authority { get; set; } // Same for Orgnization address and Contact person address
		public string JobTitle { get; set; }
		public string PropertyOwner { get; set; }
		public string searchStakeHolderName { get; set; }
		public string OrganizationName { get; set; }
		public int ParcelTaxID { get; set; }

		public AddressInfo AddressInfo { get; set; }
	}
}