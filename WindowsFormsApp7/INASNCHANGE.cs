//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp7
{
    using System;
    using System.Collections.Generic;
    
    public partial class INASNCHANGE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INASNCHANGE()
        {
            this.INASNCHANGE_D = new HashSet<INASNCHANGE_D>();
        }
    
        public string id { get; set; }
        public string cticketcode { get; set; }
        public string cstatus { get; set; }
        public string data_sources { get; set; }
        public string execute_owner { get; set; }
        public Nullable<System.DateTime> execute_time { get; set; }
        public string cauditperson { get; set; }
        public Nullable<System.DateTime> daudittime { get; set; }
        public string create_owner { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public string last_upd_owner { get; set; }
        public Nullable<System.DateTime> last_upd_time { get; set; }
        public string cmemo { get; set; }
        public string changetype { get; set; }
        public string inasn_cticketcode { get; set; }
        public string inasn_d { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INASNCHANGE_D> INASNCHANGE_D { get; set; }
    }
}
