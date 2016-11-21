using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntities
{
    public class InstClsSectionMapping
    {
        public int instclssection_id { get; set; }
        public int institution_id { get; set; }
        public int class_id { get; set; }
        public int section_id { get; set; }
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z\\s]+$")]
        public Nullable<int> instclssection_strength { get; set; }
        public Nullable<int> instclssection_teacher_id { get; set; }
    }
}

