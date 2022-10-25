using _1.DAL.Context;
using _1.DAL.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{  
    public interface ICTSPRepositories
    {
        bool Add(ChiTietSp ctsp);
        bool Update(ChiTietSp ctsp);
        bool Delete(ChiTietSp ctsp);
        List<ChiTietSp> GetAll();
    }
}
