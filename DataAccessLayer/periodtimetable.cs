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
    
    public partial class periodtimetable
    {
        public int pttable_id { get; set; }
        public Nullable<int> timetable_id { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
        public Nullable<int> period_no { get; set; }
        public string teacher_name { get; set; }
        public string day { get; set; }
        public string subject { get; set; }
    }
}
