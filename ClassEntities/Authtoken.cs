using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntities
{
   public class Authtoken
    {
        public string token_key { get; set; }
        public DateTime token_expiry { get; set; }
        public DateTime crdate { get; set; }
    }
}
