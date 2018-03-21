using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOSBPM.Models
{
    public class OccupancyHeightsandAreas
    {
        public string PrimaryUse { get; set; }
        public string ConstructionType { get; set; }

        public string  abandoned { get; set; }

        public string ApplicantComments { get; set; }

        public string ReviewerComments { get; set; }
        public double BuildingHeightinStories { get; set; }
        public double BuildingHeightinFeets { get; set; }
        public double FloorAreainStories { get; set; }
        public double FloorAreainFeets { get; set; }
        public int BuildingYear { get; set; }
       
        
    }
}