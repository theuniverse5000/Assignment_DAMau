using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IGioHangRepositories
    {
        bool Add(GioHang gh);
        bool Update(GioHang gh);
        bool Delete(GioHang gh);
        List<GioHang> GetAll();
    }
}
