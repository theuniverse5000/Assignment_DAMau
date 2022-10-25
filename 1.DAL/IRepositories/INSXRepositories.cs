using _1.DAL.DomainClass;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepositories
{
    public interface INSXRepositories
    {
        //bool Add(string ma,string ten );
        //bool Update(Guid id,string ma,string ten);
        //bool Delete(Guid id);
        //List<Nsx> GetAll();
        bool Add(Nsx nsx);
        bool Update(Nsx nsx);
        bool Delete(Nsx nsx);
        List<Nsx> GetAll();
    }
}
