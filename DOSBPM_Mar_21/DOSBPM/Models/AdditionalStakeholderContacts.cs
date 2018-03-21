using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DOSBPM.Models
{
    public class AdditionalStakeholderContacts
    {

        public string Suffix { get; set; }

        public string ContactPerson { get; set; }

        public string County { get; set; }
        [Required]
        public string Country { get; set; }

        public string State { get; set; }

        public string Exceptions { get; set; }

        public string Comments { get; set; }
    }
}