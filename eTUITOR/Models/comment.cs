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
    
    public partial class comment
    {
        public int comment_id { get; set; }
        public Nullable<int> student_id { get; set; }
        public string content { get; set; }
        public Nullable<int> tutor_id { get; set; }
    
        public virtual student student { get; set; }
        public virtual tutor tutor { get; set; }
    }
}
