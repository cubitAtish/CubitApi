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
    
    public partial class institution
    {
        public institution()
        {
            this.students = new HashSet<student>();
        }
    
        public int institution_id { get; set; }
        public int user_id { get; set; }
        public int institution_country { get; set; }
        public int institution_state { get; set; }
        public int institution_city { get; set; }
        public string institution_name { get; set; }
        public string institution_address { get; set; }
        public string institution_website { get; set; }
        public string institution_poc { get; set; }
        public Nullable<int> institution_nostudents { get; set; }
        public int institution_class_id { get; set; }
    
        public virtual ICollection<student> students { get; set; }
    }
}
