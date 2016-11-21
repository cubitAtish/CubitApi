using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntities
{
    public class Section
    {
        public int section_id { get; set; }
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z\\s]+$")]
        public string section_name { get; set; }
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z\\s]+$")]
        public string section_description { get; set; }
    }
}
