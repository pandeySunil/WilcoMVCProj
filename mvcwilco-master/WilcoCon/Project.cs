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
    
    public partial class Project
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Project()
        {
            this.PayScales = new HashSet<PayScale>();
        }
    
        public int ProjectId { get; set; }
        public string ProjectLocation { get; set; }
        public string ProjectDescription { get; set; }
        public int DistanceFromUnionHall { get; set; }
        public string ProjectSupervisor { get; set; }
        public string ProjectNumber { get; set; }
        public bool Active { get; set; }
        public int CustomerId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PayScale> PayScales { get; set; }
    }
}
