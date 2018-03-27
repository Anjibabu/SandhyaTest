using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSBPM.Models
{
	public class IndividualInformation :AddressInfo
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}