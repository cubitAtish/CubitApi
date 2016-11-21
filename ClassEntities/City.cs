using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
   public class City 
    {
        public Int16 city_id { get; set; }
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z\\s]+$")]
        public string city_name { get; set; }
        public Int16 city_stateid { get; set; }
        public bool city_isactive { get; set; }
    }
}
