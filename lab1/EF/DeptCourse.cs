//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab1.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeptCourse
    {
        public int ID { get; set; }
        public int Cid { get; set; }
        public int Sid { get; set; }
        public System.DateTime Time { get; set; }
    
        public virtual Cours Cours { get; set; }
        public virtual Student Student { get; set; }
    }
}