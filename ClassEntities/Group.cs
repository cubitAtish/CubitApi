using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassEntities
{
  public  class Group
    {
        public int group_id { get; set; }
        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[ A-Za-z0-9_@./#&+-]*$")]
        public string group_name { get; set; }
        public bool group_isactive { get; set; }
        [StringLength(50)]
        [RegularExpression(@"^[ A-Za-z0-9_@./#&+-]*$")]
        public string group_description { get; set; }
        public int group_privacy { get; set; }
        public int user_id { get; set; }
    }
}
