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
    
    public partial class OUT_GROUP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OUT_GROUP()
        {
            this.OUT_GROUP_D = new HashSet<OUT_GROUP_D>();
        }
    
        public string id { get; set; }
        public string group_name { get; set; }
        public string remark { get; set; }
        public string create_owner { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
        public string last_upd_owner { get; set; }
        public Nullable<System.DateTime> last_upd_date { get; set; }
        public Nullable<decimal> cstatus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OUT_GROUP_D> OUT_GROUP_D { get; set; }
    }
}
