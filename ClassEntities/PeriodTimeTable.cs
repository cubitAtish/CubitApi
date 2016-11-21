using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
   public  class PeriodTimeTable : TimeTable
    {
        public int pttable_id { get; set; }
        public string starttime { get; set; }
        public string endtime { get; set; }
        public int? period_no { get; set; }
        public string teacher_name { get; set; }
        public string day { get; set; }
        public string subject { get; set; }
    }
}
