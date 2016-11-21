using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
   public class ExamReportMapping
    {
        public int erm_id { get; set; }
        public int erm_section_id { get; set; }
        public int erm_class_id { get; set; }
        public int erm_institution_id { get; set; }
        public string exam_term { get; set; }
    }
}
