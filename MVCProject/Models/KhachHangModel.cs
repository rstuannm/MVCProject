using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public class KhachHangModel
    {
        public string MsgError { get; set; }

        [Display(Name = "ID:")]
        public string user_cd { get; set; }

        [Display(Name = "Tên:")]
        [StringLength(255)]
        public string name { get; set; }

        [Display(Name = "Tên đăng nhập:")]
        [Required]
        [StringLength(8)]
        public string user_name { get; set; }

        [Display(Name = "Mật khẩu:")]
        [Required]
        [StringLength(255)]
        public string pass_word { get; set; }

        [Display(Name = "Điện thoại:")]
        [StringLength(255)]
        public string mobile { get; set; }

        [Display(Name = "Email:")]
        [StringLength(255)]
        public string email { get; set; }

        [Display(Name = "Địa chỉ:")]
        [StringLength(255)]
        public string adress { get; set; }

        [Display(Name = "Giới tính:")]
        public bool? sex { get; set; }

        public bool? del_flg { get; set; }

        public DateTime? create_date { get; set; }

        [StringLength(8)]
        public string create_user { get; set; }

        public DateTime? update_date { get; set; }

        [StringLength(8)]
        public string update_user { get; set; }


    }
}