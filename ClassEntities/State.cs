using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntities
{
   public  class State 
    {
        public Int16 state_id { get; set; }
        public string state_name { get; set; }
        public Int16 state_countryid { get; set; }
        public bool state_isactive { get; set; }
    }
}
