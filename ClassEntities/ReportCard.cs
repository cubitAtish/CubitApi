using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ClassEntities
{
   public class ReportCard : ExamSchedule
    {
        public int recard_id { get; set; }
        public int student_id { get; set; }
        public int marks { get; set; }
        public string grade { get; set; }  
        //public int? subject_id { get; set; }     
    }
}
