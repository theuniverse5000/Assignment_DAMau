using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IHoaDonRepositories

    {
        bool Add(HoaDon hd);
        bool Update (HoaDon hd); 
        bool Delete(HoaDon hd);
        List<HoaDon> GetAll();
        
    }
}
