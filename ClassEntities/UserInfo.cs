using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntities
{
    public class UserInfo
    {

        public int user_id { get; set; }
        [Required]
        [StringLength(50)]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z\\s]+$")]
        public string user_name { get; set; }
        [Required]
        public string user_email { get; set; }
        [Required]
        [StringLength(12, MinimumLength = 8)]
        public string user_password { get; set; }
        public Nullable<bool> user_isactive { get; set; }
        public Nullable<bool> user_locked { get; set; }
        public Nullable<int> user_failedattempt { get; set; }
        public Nullable<System.DateTime> user_lockedtilldate { get; set; }
        public Nullable<int> user_type { get; set; }
        public DateTime user_crdate { get; set; }
        public Nullable<int> user_crby { get; set; }
        public Nullable<System.DateTime> user_upddate { get; set; }
        public Nullable<int> user_updby { get; set; }
        public string user_alternatemail { get; set; }
        public string pwdchange_oldpwd { get; set; }
        public string pwdchange_newpwd { get; set; }
        public DateTime pwdchange_redate { get; set; }
        public DateTime pwdchange_upddate { get; set; }
        public string pwdchange_guid { get; set; }
    }
}
