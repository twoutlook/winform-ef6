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
    
    public partial class BAR_SN_SPLIT_D
    {
        public string ids { get; set; }
        public string id { get; set; }
        public string split_sn { get; set; }
        public decimal split_sn_qty { get; set; }
        public string createowner { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
    
        public virtual BAR_SN_SPLIT BAR_SN_SPLIT { get; set; }
    }
}