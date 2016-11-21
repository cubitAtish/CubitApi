using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
  public  class TimeTable
    {
        public int timetable_id { get; set; }
        public int class_id { get; set; }
        public int section_id { get; set; }
        public int institution_id { get; set; }
        public bool isactive { get; set; }
        public string createdby { get; set; }
        public DateTime createddate { get; set; }
    }
}
