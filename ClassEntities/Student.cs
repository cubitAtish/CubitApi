using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
    public class Student : UserPersonalInfo
    {
        public int student_id { get; set; }
        [Required]
        [StringLength(20)]
        public string student_regid { get; set; }
        [StringLength(100)]
        public string student_father_name { get; set; }
        [StringLength(100)]
        public string student_mother_name { get; set; }
        [Required]
        public int student_roll_no { get; set; }
        public int? student_section { get; set; }
        [Required]
        public int student_class { get; set; }
        [Required]
        public int student_institution_id { get; set; }
        [StringLength(200)]
        public string student_cca { get; set; }
        [StringLength(200)]
        public string student_eca { get; set; }
    }
}
