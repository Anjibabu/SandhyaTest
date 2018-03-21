using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSBPM.Models
{
    public class TypeofConstruction
    {
        public string txtStoragePlan { get; set; }
        public string txtFRPrimaryStructuralFrame { get; set; }
        public string txtFRBearingWalls_Exterior { get; set; }
        public string txtFRBearingWalls_Interior { get; set; }
        public string txtFRNonBearingWalls_Exterior { get; set; }
        public string txtFRNonBearingWalls_Interior { get; set; }
        public string txtFRFloorConstruction { get; set; }
        public string txtFRRoofConstruction { get; set; }

        public string txtCalPrimaryStructuralFrame { get; set; }
        public string txtCalBearingWalls_Exterior { get; set; }
        public string txtCalBearingWalls_Interior { get; set; }
        public string txtCalNonBearingWalls_Exterior { get; set; }
        public string txtCalNonBearingWalls_Interior { get; set; }
        public string txtCalFloorConstruction { get; set; }
        public string txtCalRoofConstruction { get; set; }

        public string txtCCD { get; set; }
        public string txtCIS { get; set; }
        public string txtPgNo { get; set; }
        public string txtApplicantComments { get; set; }
        public string txtBackOffComments { get; set; }

    }
}