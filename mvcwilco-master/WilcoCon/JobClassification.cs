//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WilcoCon
{
    using System;
    using System.Collections.Generic;
    
    public partial class JobClassification
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public JobClassification()
        {
            this.PayScales = new HashSet<PayScale>();
        }
    
        public int SkillId { get; set; }
        public string JobType { get; set; }
        public string SkillCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayScale> PayScales { get; set; }
    }
}
