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
    
    public partial class TimeCard
    {
        public int TimeCardId { get; set; }
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }
        public int ProjectId { get; set; }
        public System.DateTime Date { get; set; }
        public System.TimeSpan TimeIn { get; set; }
        public System.TimeSpan TimeOut { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
