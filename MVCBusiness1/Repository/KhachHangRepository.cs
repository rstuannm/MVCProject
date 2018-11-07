using MVCBusiness1.DataContext;
using MVCBusiness1.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBusiness1.Repository
{
    public class KhachHangRepository : IKhachHangRepository
    {
        MVCDataContext _db = new MVCDataContext();
        public bool Add(KhachHang model)
        {
            try
            {
                _db.KhachHangs.Add(model);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<KhachHang> getLst()
        {
            var data = (from a in _db.KhachHangs
                       select a).ToList();
            return data;
        }
    }
}
