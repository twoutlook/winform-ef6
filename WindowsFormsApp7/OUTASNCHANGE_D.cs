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
    
    public partial class OUTASNCHANGE_D
    {
        public string ids { get; set; }
        public string id { get; set; }
        public string cstatus { get; set; }
        public string cinvcode { get; set; }
        public string cinvname { get; set; }
        public Nullable<decimal> oldnum { get; set; }
        public Nullable<decimal> nownum { get; set; }
        public string cerpcodeline { get; set; }
        public string create_owner { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public string last_upd_owner { get; set; }
        public Nullable<System.DateTime> last_upd_time { get; set; }
        public string cmemo { get; set; }
        public string outasn_cticketcode { get; set; }
        public string outans_id { get; set; }
        public string transtype { get; set; }
        public string reversealloid { get; set; }
        public string asn_d_ids { get; set; }
    
        public virtual OUTASNCHANGE OUTASNCHANGE { get; set; }
    }
}
