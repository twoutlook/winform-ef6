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
    
    public partial class ALLOCATE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ALLOCATE()
        {
            this.ALLOCATE_D = new HashSet<ALLOCATE_D>();
            this.ALLOCATE_D_MERGE = new HashSet<ALLOCATE_D_MERGE>();
        }
    
        public string id { get; set; }
        public string ccreateownercode { get; set; }
        public System.DateTime dcreatetime { get; set; }
        public string cauditperson { get; set; }
        public Nullable<System.DateTime> daudittime { get; set; }
        public string cticketcode { get; set; }
        public string cstatus { get; set; }
        public string cerpcode { get; set; }
        public string cmemo { get; set; }
        public System.DateTime dindate { get; set; }
        public string cdefine1 { get; set; }
        public string cdefine2 { get; set; }
        public Nullable<System.DateTime> ddefine3 { get; set; }
        public Nullable<System.DateTime> ddefine4 { get; set; }
        public Nullable<decimal> idefine5 { get; set; }
        public Nullable<decimal> is_allow { get; set; }
        public Nullable<decimal> special { get; set; }
        public Nullable<decimal> special_type { get; set; }
        public string inasncode { get; set; }
        public string deliveryuser { get; set; }
        public Nullable<System.DateTime> deliverytime { get; set; }
        public string otype { get; set; }
        public Nullable<System.DateTime> debittime { get; set; }
        public string debitowner { get; set; }
        public Nullable<decimal> is_merge { get; set; }
        public string merge_id { get; set; }
        public string merge_erp { get; set; }
        public string lineid { get; set; }
        public Nullable<decimal> critical_part { get; set; }
        public string ALLOTYPE { get; set; }
        public string palletcode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALLOCATE_D> ALLOCATE_D { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ALLOCATE_D_MERGE> ALLOCATE_D_MERGE { get; set; }
    }
}
