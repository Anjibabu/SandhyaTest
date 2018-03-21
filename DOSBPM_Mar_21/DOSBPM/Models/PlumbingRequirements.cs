using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSBPM.Models
{
    public class PlumbingRequirements
    {
        public string txtExpPlumbingFix { get; set; }
        public string txtExpMaterialsIdentified { get; set; }
        public string txtExpFloorDrains { get; set; }
        public string txtExpOilWaterSep { get; set; }
        public string txtExpGreaseTraps { get; set; }
        public string txtExpBackflowPrevention { get; set; }
        public string txtExpSeismicRestraints { get; set; }
        public string txtExpAdditionalInfo { get; set; }

        public string txtCCD { get; set; }
        public string txtCIS { get; set; }
        public string txtPgNo { get; set; }
        public string txtApplicantComments { get; set; }
        public string txtBackOffComments { get; set; }
    }
}