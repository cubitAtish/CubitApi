//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class quizresult
    {
        public int qui_res_id { get; set; }
        public int erm_id { get; set; }
        public int student_id { get; set; }
        public Nullable<int> subject_id { get; set; }
        public Nullable<int> ques_id { get; set; }
        public string select_ans { get; set; }
        public Nullable<bool> result { get; set; }
    }
}
