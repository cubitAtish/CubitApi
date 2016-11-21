using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntities
{
   public class UserPersonalInfo : UserInfo
    {
        [Required]
        //[DataType(DataType.Date)]
        public DateTime? userper_dob { get; set; }
        [Required]
        public int? userper_gender { get; set; }
        [Required]
        public int? userper_countryid { get; set; }
        [Required]
        public int? userper_stateid { get; set; }
        [Required]
        public int? userper_cityid { get; set; }
        public string userper_favoiritesubjects { get; set; }
        public string userper_sports { get; set; }
        public string userper_hobbies { get; set; }
        public string userper_personalities { get; set; }
        public string userper_books { get; set; }
        public string userper_movies { get; set; }
        public string userper_mobile { get; set; }
        public string userper_alternatemobile { get; set; }
        public string userper_profile_pic { get; set; }

    }
}
