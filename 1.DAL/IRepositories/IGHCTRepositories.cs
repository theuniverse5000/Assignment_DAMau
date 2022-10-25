using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IGHCTRepositories
    {
        bool Add(GioHangChiTiet ghct);
        bool Update(GioHangChiTiet ghct);
        bool Delete(GioHangChiTiet ghct);
        List<GioHangChiTiet> GetAll();
    }
}
