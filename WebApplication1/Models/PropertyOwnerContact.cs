using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DOSBPM.Models
{
    public class PropertyOwnerContact
    {
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LasttName { get; set; }
        public string Suffix { get; set; }
        [Required]
        public int TelephoneNumber { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string MailingAddressLine1 { get; set; }
        public string MailingAddressLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int Zip { get; set; }
        public int Zip4 { get; set; }
        [Required]
        public string County { get; set; }
        [Required]
        public string Country { get; set; }
        public string Comments { get; set; }
      
    }
}