using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Models
{
    public class PropertyOwnerInfo : AddressInfo
    {
        
        public string PropertyOwnerType { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LasttName { get; set; }
        public string Suffix { get; set; }

        public int TelephoneNumber { get; set; }

        public string EmailAddress { get; set; }
        [Required]
        public string MailingAddressLine1 { get; set; } // Same for Orgnization address and Contact person address
        public string MailingAddressLine2 { get; set; } // Same for Orgnization address and Contact person address
        public string SiteDirection { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }

        public int Zip { get; set; }
        public int Zip4 { get; set; }

        public string County { get; set; }

        public string Country { get; set; }
        public string Comments { get; set; }

        public string TransType { get; set; }
        public string Authority { get; set; } // Same for Orgnization address and Contact person address
        public string JobTitle { get; set; }
        public string PropertyOwner { get; set; }
        public string searchStakeHolderName { get; set; }

        //DropDowns
        //public IEnumerable<SelectListItem> Counties { get; set; }

        // Organization Address details
        public string OrganizationName { get; set; }
        public int ParcelTaxID { get; set; }
         
		public AddressInfo AddressInfo{ get; set; }


	}
}