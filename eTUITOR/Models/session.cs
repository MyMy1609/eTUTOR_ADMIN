//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eTUITOR.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class session
    {
        public int session_id { get; set; }
        public Nullable<int> tutor_id { get; set; }
        public Nullable<int> student_id { get; set; }
        public string @class { get; set; }
        public Nullable<System.TimeSpan> start_time { get; set; }
        public Nullable<System.TimeSpan> end_time { get; set; }
        public Nullable<int> total_sessions { get; set; }
        public string day_otw { get; set; }
        public Nullable<int> status_id { get; set; }
        public Nullable<int> status_tutor { get; set; }
        public Nullable<int> status_admin { get; set; }
        public Nullable<int> subject_id { get; set; }
        public Nullable<System.DateTime> dateCreate { get; set; }
    
        public virtual subject subject { get; set; }
        public virtual status status { get; set; }
        public virtual status status1 { get; set; }
        public virtual status status2 { get; set; }
        public virtual student student { get; set; }
        public virtual tutor tutor { get; set; }
    }
}
