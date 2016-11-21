using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
   public class HomeWork
    {
        public int homework_id { get; set; }
        public int hw_institution_id { get; set; }
        public int? hw_section_id { get; set; }
        public int? hw_class_id { get; set; }
        public int hw_teacher_id { get; set; }
        public int hw_subject_id { get; set; }
        public string hw_description { get; set; }
        public DateTime hw_date { get; set; }
        public bool isactive { get; set; }

    }
}
