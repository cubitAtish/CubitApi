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
    
    public partial class usergroup
    {
        public int usergroup_id { get; set; }
        public int group_id { get; set; }
        public int fromuser_id { get; set; }
        public int touser_id { get; set; }
    
        public virtual group group { get; set; }
    }
}
