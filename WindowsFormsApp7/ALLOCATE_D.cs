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
    
    public partial class ALLOCATE_D
    {
        public string ids { get; set; }
        public string id { get; set; }
        public string cstatus { get; set; }
        public decimal iquantity { get; set; }
        public string cpositioncode { get; set; }
        public string cposition { get; set; }
        public string cinvbarcode { get; set; }
        public string cinvcode { get; set; }
        public string cinvname { get; set; }
        public System.DateTime dindate { get; set; }
        public string cinpersoncode { get; set; }
        public string cmemo { get; set; }
        public string cdefine1 { get; set; }
        public string cdefine2 { get; set; }
        public Nullable<System.DateTime> ddefine3 { get; set; }
        public Nullable<System.DateTime> ddefine4 { get; set; }
        public Nullable<decimal> idefine5 { get; set; }
        public string ctopositioncode { get; set; }
        public string ctoposition { get; set; }
        public string cmidpositioncode { get; set; }
        public Nullable<decimal> ioriquantity { get; set; }
        public Nullable<decimal> toallocount { get; set; }
        public string outbill_d_ids { get; set; }
        public string allo_type { get; set; }
        public Nullable<decimal> sptype { get; set; }
        public string cmidpositionname { get; set; }
        public Nullable<decimal> is_upline { get; set; }
        public Nullable<decimal> is_scan { get; set; }
        public Nullable<decimal> part_bond { get; set; }
        public Nullable<decimal> critical_part { get; set; }
        public Nullable<decimal> asrs_status { get; set; }
        public Nullable<decimal> wmstskid { get; set; }
        public Nullable<decimal> asrs_num { get; set; }
        public string lineid { get; set; }
    
        public virtual ALLOCATE ALLOCATE { get; set; }
    }
}
