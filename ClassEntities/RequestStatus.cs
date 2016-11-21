using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntities
{
   public class RequestStatus
    {
        public int requeststatus_id { get; set; }
        public int request_from { get; set; }
        public int request_to { get; set; }
        public Int16 request_status { get; set; }
        public  int request_for_group { get; set; }
        public string request_note { get; set; }
        public DateTime request_crdate { get; set; }
        public DateTime request_upddate { get; set; }
    }
}
