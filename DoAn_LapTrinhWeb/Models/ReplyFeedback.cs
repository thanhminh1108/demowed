//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn_LapTrinhWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReplyFeedback
    {
        public int rep_feedback_id { get; set; }
        public string content { get; set; }
        public string stastus { get; set; }
        public System.DateTime create_at { get; set; }
        public int feedback_id { get; set; }
        public int account_id { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Feedback Feedback { get; set; }
    }
}