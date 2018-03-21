using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DOSBPM.Models
{
    public class BuildingInfo
    {
        [Required]
        public string County { get; set; }
        [Required]
        public string Country { get; set; }

        public string Directions { get; set; }
    }
}