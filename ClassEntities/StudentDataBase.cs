using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntities
{
   public class StudentDataBase
    {
        //report card
        public int recard_id { get; set; }
        public int student_id { get; set; }
        public int marks { get; set; }
        public string grade { get; set; }
        //student
        public string student_regid { get; set; }       
        public string student_father_name { get; set; }    
        public string student_mother_name { get; set; }   
        public int student_roll_no { get; set; }
        public int? student_section { get; set; }    
        public int student_class { get; set; } 
        public int student_institution_id { get; set; }    
        public string student_cca { get; set; }      
        public string student_eca { get; set; }
        //userinfo
        public string user_name { get; set; }
        //userperinfo
        public int? userper_gender { get; set; }
        public DateTime? userper_dob { get; set; }
    }
}
