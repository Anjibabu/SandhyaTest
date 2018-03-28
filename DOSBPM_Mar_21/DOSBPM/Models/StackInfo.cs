using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSBPM.Models
{
	public class StackInfo : AddressInfo
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Middle { get; set; }
		public string Suffix { get; set; }
		public string OrgName { get; set; }
		public string OrgAuthority { get; set; }

	}
}