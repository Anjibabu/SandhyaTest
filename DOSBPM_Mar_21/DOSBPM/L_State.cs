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
    
    public partial class L_State
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public L_State()
        {
            this.L_County = new HashSet<L_County>();
            this.T_Address = new HashSet<T_Address>();
        }
    
        public string State_ID { get; set; }
        public string State_Name { get; set; }
        public string State_ShortName { get; set; }
        public string Country_ID { get; set; }
    
        public virtual L_Country L_Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<L_County> L_County { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Address> T_Address { get; set; }
    }
}
