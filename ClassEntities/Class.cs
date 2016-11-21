using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
   public class Class
    {
        public int class_id { get; set; }
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z\\s]+$")]
        public string class_name { get; set; }
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z\\s]+$")]
        public string class_description { get; set; }
    }
}
