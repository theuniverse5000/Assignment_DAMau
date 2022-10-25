using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repositories
{
    public class SanPhamRepositories : ISanPhamRepositories
    {
        private FpolyDBContext context;
        public SanPhamRepositories()
        {
            context = new FpolyDBContext();
        }
        public bool Add(SanPham sp)
        {
            if (sp == null) return false;
            context.SanPhams.Add(sp);
            context.SaveChanges();
            return true;
        }

        public bool Delete(SanPham sp)
        {
            if (sp == null) return false;
            var thao = context.SanPhams.FirstOrDefault(a=>a.Id == sp.Id);   
            context.Remove(thao);
            context.SaveChanges();
            return true;
        }

        public List<SanPham> GetAll()
        {
           return context.SanPhams.ToList();    
        }

        public bool Update(SanPham sp)
        {
            if (sp == null) return false;
            var thao = context.SanPhams.FirstOrDefault(a => a.Id == sp.Id);
            thao.Ma = sp.Ma;
            thao.Ten=sp.Ten;    
            context.Update(thao);
            context.SaveChanges();
            return true;
        }
    }
}
