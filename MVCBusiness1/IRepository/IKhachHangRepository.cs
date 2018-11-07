using MVCBusiness1.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBusiness1.IRepository
{
    public interface IKhachHangRepository
    {
        List<KhachHang> getLst();
        bool Add(KhachHang model);
    }
}
