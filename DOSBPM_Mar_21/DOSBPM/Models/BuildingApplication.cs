using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSBPM.Models
{
    public class BuildingApplication
    {
        public QualifyingInfo QualifyingInfoData { get; set; }
        public PropertyOwnerInfo PropertyOwnerInfoData { get; set; }
        public PropertyOwnerContactInfo PropertyOwnerContactData { get; set; }
        public BuildingInfo BuildingData { get; set; }
    }
}