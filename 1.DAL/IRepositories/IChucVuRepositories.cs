using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface IChucVuRepositories
    {
        bool Add(ChucVu cv);
        bool Update(ChucVu cv);
        bool Delete(ChucVu cv); 
        List<ChucVu> GetAll();
    }
}
