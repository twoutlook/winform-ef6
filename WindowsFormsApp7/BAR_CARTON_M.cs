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
    
    public partial class BAR_CARTON_M
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BAR_CARTON_M()
        {
            this.BAR_CARTON_D = new HashSet<BAR_CARTON_D>();
        }
    
        public string id { get; set; }
        public string carton_no { get; set; }
        public string carton_name { get; set; }
        public string type_id { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
        public string createowner { get; set; }
        public Nullable<System.DateTime> lastmodifytime { get; set; }
        public string lastmodifyownere { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAR_CARTON_D> BAR_CARTON_D { get; set; }
    }
}