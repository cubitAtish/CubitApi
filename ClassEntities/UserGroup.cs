using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntities
{
   public  class UserGroup
    {
        public int usergroup_id { get; set; }
        public int group_id { get; set; }
        public int fromuser_id { get; set; }
        public int touser_id { get; set; }
    }
}
