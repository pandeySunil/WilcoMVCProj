
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace WilcoCon.Models
{

using System;
    using System.Collections.Generic;
    
public partial class JobClassification
{

    public JobClassification()
    {

        this.PayScales = new HashSet<PayScale>();

        this.TimeCards = new HashSet<TimeCard>();

    }


    public int SkillId { get; set; }

    public string JobType { get; set; }

    public string SkillCode { get; set; }



    public virtual ICollection<PayScale> PayScales { get; set; }

    public virtual ICollection<TimeCard> TimeCards { get; set; }

}

}
