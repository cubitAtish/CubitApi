using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
   public class Teacher :UserPersonalInfo
    {
        public  int teacher_id { get; set; }     
        public string teacher_code { get; set; }
        public int teacher_institution_id { get; set; }
    }
}
