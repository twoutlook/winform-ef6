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
    
    public partial class V_WmsAndEbsQtyDiffReport
    {
        public string id { get; set; }
        public string warehouseid { get; set; }
        public string cwarename { get; set; }
        public string positionid { get; set; }
        public string cposition { get; set; }
        public string cpartname { get; set; }
        public string cpartnumber { get; set; }
        public decimal ebs_stock_qty { get; set; }
        public decimal wms_stock_qty { get; set; }
        public decimal discrepency_qty { get; set; }
        public System.DateTime create_time { get; set; }
        public string cspecifications { get; set; }
    }
}
