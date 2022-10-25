using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INhanVienRepositories
    {
        bool Add(NhanVien nv);
        bool Update(NhanVien nv);
        bool Delete(NhanVien nv);
        List<NhanVien> GetAll();
        

    }
}
