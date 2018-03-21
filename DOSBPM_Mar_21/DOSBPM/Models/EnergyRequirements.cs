using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOSBPM.Controllers;

namespace DOSBPM.Models
{
    public class EnergyRequirements
    {
        public string ddlClimateZone { get; set; }

        public string ddlCompliancePath { get; set; }

        public string ddlSelectSoftware { get; set; }
        public string txtexplainAddInfo { get; set; }

        public string txtCCD { get; set; }
        public string txtCIS { get; set; }
        public string txtPgNo { get; set; }
        public string txtApplicantComments { get; set; }
        public string txtBackOffComments { get; set; }

        public string txt1CCD { get; set; }
        public string txt1CIS { get; set; }
        public string txt1PgNo { get; set; }
        public string txt1ApplicantComments { get; set; }
        public string txt1BackOffComments { get; set; }

        public string txt2CCD { get; set; }
        public string txt2CIS { get; set; }
        public string txt2PgNo { get; set; }
        public string txt2ApplicantComments { get; set; }
        public string txt2BackOffComments { get; set; }

        public string txt3CCD { get; set; }
        public string txt3CIS { get; set; }
        public string txt3PgNo { get; set; }
        public string txt3ApplicantComments { get; set; }
        public string txt3BackOffComments { get; set; }

        public string txt4CCD { get; set; }
        public string txt4CIS { get; set; }
        public string txt4PgNo { get; set; }
        public string txt4ApplicantComments { get; set; }
        public string txt4BackOffComments { get; set; }
    }
}