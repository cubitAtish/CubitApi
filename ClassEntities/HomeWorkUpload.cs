using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
    public class HomeWorkUpload :HomeWork
    {
        public int homeworkupload_id { get; set; }
       // public int homework_id { get; set; }
        public int hw_student_id { get; set; }
        public string hw_url { get; set; }
       // public Int16 isactive { get; set; }
    }
}
