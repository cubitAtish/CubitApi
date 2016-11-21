using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ClassEntities
{
   public class ExamSchedule : ExamReportMapping 
    {
        public int examsec_id { get; set; }
        public int subject_id { get; set; }
        public string subject_name { get; set; }
        public DateTime exam_date { get; set; }       
    }
}
