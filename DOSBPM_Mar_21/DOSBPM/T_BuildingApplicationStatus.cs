//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DOSBPM
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_BuildingApplicationStatus
    {
        public string BldgAppStatus_ID { get; set; }
        public System.DateTime BldgAppStatus_IssueDate { get; set; }
        public System.DateTime BldgAppStatus_ExpireDate { get; set; }
        public System.DateTime BldgAppStatus_RenewalDate { get; set; }
        public string BLdgAppInfo_ID { get; set; }
    
        public virtual T_BuildingApplicationInformation T_BuildingApplicationInformation { get; set; }
    }
}
