using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
   public class Post 
    {
        public int post_id { get; set; }        
        public string post_doc_id { get; set; }
        public List<Post> list_document_id { get; set; }
        public string post_gpslocation_id { get; set; }
        public List<Post> list_gpslocation_id { get; set; }        
        public DateTime? post_date { get; set; }
        public int post_user_type { get; set; }
        [StringLength(200)]
        public string post_feeds { get; set; }
        public string post_tag_user_id { get; set; }
        public List<Post> list_tag_user_id { get; set; }
        public string post_event_id { get; set; }
        public List<Post> list_event_id { get; set; }
        public int user_id { get; set; }
    }
}
