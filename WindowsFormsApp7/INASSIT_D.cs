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
    
    public partial class INASSIT_D
    {
        public string ids { get; set; }
        public string id { get; set; }
        public string cstatus { get; set; }
        public decimal inum { get; set; }
        public string cpositioncode { get; set; }
        public string cposition { get; set; }
        public string cinvbarcode { get; set; }
        public string cinvcode { get; set; }
        public string cinvname { get; set; }
        public string cbatch { get; set; }
        public string cmemo { get; set; }
        public string coperatorcode { get; set; }
        public string coperator { get; set; }
        public string casnid { get; set; }
        public Nullable<decimal> iasnline { get; set; }
        public string cdefine1 { get; set; }
        public string cdefine2 { get; set; }
        public Nullable<System.DateTime> ddefine3 { get; set; }
        public Nullable<System.DateTime> ddefine4 { get; set; }
        public Nullable<decimal> idefine5 { get; set; }
        public Nullable<int> CRITICAL_PART { get; set; }
    
        public virtual INASSIT INASSIT { get; set; }
    }
}