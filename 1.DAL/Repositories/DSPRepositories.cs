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
    public class DSPRepositories : IDSPRepositories
    {
        private FpolyDBContext context;
        public DSPRepositories()
        {
            context = new FpolyDBContext();
        }
        public bool Add(DongSp dsp)
        {
            if (dsp == null) return false;
          context.DongSps.Add(dsp);
            context.SaveChanges();
            return true;
        }

        public bool Delete(DongSp dsp)
        {
            if (dsp == null) return false;
            var thao = context.DongSps.FirstOrDefault(a => a.Id == dsp.Id);
            context.Remove(thao);
            context.SaveChanges();
            return true;
        }

        public List<DongSp> GetAll()
        {
            return context.DongSps.ToList();
        }

        public bool Update(DongSp dsp)
        {
            if (dsp == null) return false;
            var thao = context.DongSps.FirstOrDefault(a => a.Id == dsp.Id);
            thao.Ma=dsp.Ma;
            thao.Ten=dsp.Ten;
            context.Update(thao);
            context.SaveChanges();
            return true;
        }
        /*
         public bool Add(string ma, string ten)
        {
            DongSp thao = new DongSp();
            thao.Ma = ma;
            thao.Ten = ten;
            context.DongSps.Add(thao);
            context.SaveChanges();
            return true;
        }

        public bool Delete(Guid id)
        {
            var thao = context.DongSps.Find(id);
            context.DongSps.Remove(thao);
            context.SaveChanges();
            return true;
        }

        public List<DongSp> GetAll()
        {
            return context.DongSps.ToList();
        }

        public bool Update(Guid id, string ma, string ten)
        {
            var thao = context.DongSps.Find(id);
            thao.Ma = ma;
            thao.Ten = ten;
            context.DongSps.Update(thao);
            context.SaveChanges();
            return true;
        }
         */


    }
}
