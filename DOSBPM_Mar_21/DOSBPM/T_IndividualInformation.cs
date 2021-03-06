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
    
    public partial class T_IndividualInformation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_IndividualInformation()
        {
            this.T_IndividualAdditionalInformation = new HashSet<T_IndividualAdditionalInformation>();
            this.T_OrganizationInformation = new HashSet<T_OrganizationInformation>();
            this.T_PayeeInformation = new HashSet<T_PayeeInformation>();
        }
    
        public string IndiInfo_ID { get; set; }
        public string IndiInfo_FirstName { get; set; }
        public string IndiInfo_LastName { get; set; }
        public string IndiInfo_MiddleName { get; set; }
        public string IndiInfo_Suffix { get; set; }
        public string ContAdd_TelephoneNumber { get; set; }
        public string ContAdd_EmailID { get; set; }
        public string Address_ID { get; set; }
        public string BldgInfo_ID { get; set; }
        public string bldgAppInfo_ID { get; set; }
        public string StkHoldType_ID { get; set; }
    
        public virtual L_Suffix L_Suffix { get; set; }
        public virtual T_Address T_Address { get; set; }
        public virtual T_BuildingApplicationInformation T_BuildingApplicationInformation { get; set; }
        public virtual T_BuildingInformation T_BuildingInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_IndividualAdditionalInformation> T_IndividualAdditionalInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_OrganizationInformation> T_OrganizationInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_PayeeInformation> T_PayeeInformation { get; set; }
    }
}
