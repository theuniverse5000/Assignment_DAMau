using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class MauSacRepositories : IMauSacRepositories
    {
        private FpolyDBContext context;
        public MauSacRepositories()
        {
            context = new FpolyDBContext();
        }

        public bool Add(MauSac ms)
        {
            if (ms == null) return false;
            context.MauSacs.Add(ms);
            context.SaveChanges();
            return true;
        }

        public bool Delete(MauSac ms)
        {
            if (ms == null) return false;
            var thao = context.MauSacs.FirstOrDefault(a => a.Id == ms.Id);
            context.Remove(thao);
            context.SaveChanges();
            return true;

        }

        public List<MauSac> GetAll()
        {
            return context.MauSacs.ToList();
        }

        public bool Update(MauSac ms)
        {
            if (ms == null) return false;
            var thao = context.MauSacs.FirstOrDefault(a => a.Id == ms.Id);
            thao.Ten = ms.Ten;
            thao.Ma = ms.Ma;
            context.Update(thao);
            context.SaveChanges();
            return true;
        }
    }
}
