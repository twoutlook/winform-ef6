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
    
    public partial class BAR_SN_SPLIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAR_SN_SPLIT()
        {
            this.BAR_SN_SPLIT_D = new HashSet<BAR_SN_SPLIT_D>();
        }
    
        public string id { get; set; }
        public string split_sn { get; set; }
        public decimal split_sn_qty { get; set; }
        public string cpositioncode { get; set; }
        public string cinvcode { get; set; }
        public string createowner { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAR_SN_SPLIT_D> BAR_SN_SPLIT_D { get; set; }
    }
}
