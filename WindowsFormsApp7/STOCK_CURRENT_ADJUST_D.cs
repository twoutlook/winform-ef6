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
    
    public partial class STOCK_CURRENT_ADJUST_D
    {
        public string ids { get; set; }
        public string id { get; set; }
        public string cpositioncode { get; set; }
        public string cpositionname { get; set; }
        public string cinvcode { get; set; }
        public string cinvname { get; set; }
        public string sncode { get; set; }
        public decimal oriqty { get; set; }
        public decimal newqty { get; set; }
        public string createowner { get; set; }
        public System.DateTime createtime { get; set; }
        public string lastupdateuser { get; set; }
        public Nullable<System.DateTime> lastupdatetime { get; set; }
    
        public virtual STOCK_CURRENT_ADJUST STOCK_CURRENT_ADJUST { get; set; }
    }
}
