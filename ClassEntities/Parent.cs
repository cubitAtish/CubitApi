using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
   public  class Parent : UserPersonalInfo
    {
        public int parent_id { get; set; }
        public string parent_childeren_ids { get; set; }
        public List<UserInfo> list_childeren_id { get; set; }
        [StringLength(50)]
        public string parent_occupation { get; set; }
        [StringLength(100)]
        public string parent_nameofspouse { get; set; }
    }
}
