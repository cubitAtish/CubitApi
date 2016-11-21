using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
   public  class EventPost 
    {
        public int user_id { get; set; }
        public int event_id { get; set; }
        [StringLength(50)]
        public string event_title { get; set; }
        [StringLength(500)]
        public string event_description { get; set; }
        public DateTime? event_startdate { get; set; }
        public DateTime? event_enddate { get; set; }
        public string event_document_id { get; set; }
        public List<EventPost> list_document_id { get; set; }
        public string event_gpslocation_id { get; set; }
        public List<EventPost> list_gpslocation_id { get; set; }
        [StringLength(100)]
        public string event_venue { get; set; }
        [StringLength(20)]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z\\s]+$")]
        public int? event_user_type { get; set; }
        
    }
}
