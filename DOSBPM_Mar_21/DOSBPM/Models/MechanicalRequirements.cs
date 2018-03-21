using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSBPM.Models
{
    public class MechanicalRequirements
    {
        public string txtExpEquipmentSchedule { get; set; }
        public string txtExpLoadCals { get; set; }
        public string txtExpVentLoc { get; set; }
        public string txtExpExhaustLoc { get; set; }
        public string txtExpDuctDamperLoc { get; set; }
        public string txtExpSmokeControl { get; set; }
        public string txtExpMakeUpAir { get; set; }
        public string txtExpEnvironments { get; set; }
        public string txtExpCookingEquipment { get; set; }
        public string txtExpAltHeatingSys { get; set; }
        public string txtExpSeismicRestraints { get; set; }
        public string txtExpAdditionalInfo { get; set; }

        public string txtCCD { get; set; }
        public string txtCIS { get; set; }
        public string txtPgNo { get; set; }
        public string txtApplicantComments { get; set; }
        public string txtBackOffComments { get; set; }
    }
}