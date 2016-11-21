using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
    public class GPSLocation 
    {
        public int user_id { get; set; }
        public int gpslocation_id { get; set; }
        [StringLength(100)]
        public string gpslocation_discription { get; set; }
        [StringLength(100)]
        public string gpslocation_name { get; set; }
        [StringLength(50)]
        public string gpslocation_location { get; set; }
    }
}
