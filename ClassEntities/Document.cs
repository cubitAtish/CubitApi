using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
   public class Document 
    {
        public int user_id { get; set; }
        public int doc_id { get; set; }
        [StringLength(100)]
        public string doc_url { get; set; }
        [StringLength(100)]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z\\s]+$")]
        public string doc_name { get; set; }
        [StringLength(100)]
        public string doc_description { get; set; }
        public DateTime doc_uploaddate { get; set; }
        [StringLength(5)]
        public string doc_extension { get; set; }
        public string doc_size { get; set; }
    }
}
