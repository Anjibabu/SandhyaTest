using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSBPM.Models
{
    public class SafeguardsDuringConstruction
    {
        public string txtExplainStoragePlan { get; set; }
        public string txtExplainPedestrianProtection { get; set; }
        public string txtExplainFireExt { get; set; }
        public string txtExplainAdditionalInfo { get; set; }
        //StoragePlan
        public string txtCCD { get; set; }
        public string txtCIS { get; set; }
        public string txtPgNo { get; set; }
        public string txtApplicantComments { get; set; }
        public string txtBackOffComments { get; set; }

        //PedestrianProtection
        public string txt1CCD { get; set; }
        public string txt1CIS { get; set; }
        public string txt1PgNo { get; set; }
        public string txt1ApplicantComments { get; set; }
        public string txt1BackOffComments { get; set; }

        //Fire Extinguisher
        public string txt2CCD { get; set; }
        public string txt2CIS { get; set; }
        public string txt2PgNo { get; set; }
        public string txt2ApplicantComments { get; set; }
        public string txt2BackOffComments { get; set; }

        //Additional Information
        public string txt3CCD { get; set; }
        public string txt3CIS { get; set; }
        public string txt3PgNo { get; set; }
        public string txt3ApplicantComments { get; set; }
        public string txt3BackOffComments { get; set; }
    }
}