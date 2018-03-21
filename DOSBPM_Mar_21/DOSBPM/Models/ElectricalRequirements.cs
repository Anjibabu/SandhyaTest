using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSBPM.Models
{
    public class ElectricalRequirements
    {
        public string txtExplainEmergencySys { get; set; }
        public string ddlTypeofSystem { get; set; }
        public string txtAddElectricalFeatures { get; set; }
        public string txtNoLoadAnalysis { get; set; }
        public string txtExplainSysReqReason { get; set; }

        public string txtCCD { get; set; }
        public string txtCIS { get; set; }
        public string txtPgNo { get; set; }
        public string txtApplicantComments { get; set; }
        public string txtBackOffComments { get; set; }
    }
}