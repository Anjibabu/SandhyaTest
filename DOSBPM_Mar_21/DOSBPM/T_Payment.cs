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
    
    public partial class T_Payment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Payment()
        {
            this.T_PayeeInformation = new HashSet<T_PayeeInformation>();
        }
    
        public string PmtInfo_ID { get; set; }
        public string PmtInfo_AmountDue { get; set; }
        public string PmtInfo_AmountReceived { get; set; }
        public string PmtInfo_OverPayment { get; set; }
        public string PmtInfo_RefundDue { get; set; }
        public string BLdgAppInfo_ID { get; set; }
    
        public virtual T_BuildingApplicationInformation T_BuildingApplicationInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_PayeeInformation> T_PayeeInformation { get; set; }
    }
}
