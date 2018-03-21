using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DOSBPM.Models
{
    public class QualifyingInfo
    {
        public SelectList TransactionTypes { get; set; }

        public string TransactionType { get; set;}
        public bool IsExistingBuilding { get; set; }
        public bool IsNewConstruction { get; set; }

		public bool IsPartialDemolition { get; set; }
		public bool IsEntireBuildingDemolition { get; set; }

    }
}