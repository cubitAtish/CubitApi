using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntities
{
    public class Subject
    {
        public int subject_id { get; set; }
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z\\s]+$")]
        public string subject_name { get; set; }
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z\\s]+$")]
        public string subject_syllabus { get; set; }
    }
}
