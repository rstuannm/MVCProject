using MVCBusiness1.DataContext;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.ViewModels
{
    public class KhachHangVM
    {
        public KhachHangVM()
        {
            lst = new List<KhachHang>();
        }
        public KhachHangModel input { get; set; }
        public List<KhachHang> lst { get; set; }
}
}