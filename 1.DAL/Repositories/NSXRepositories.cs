using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class NSXRepositories : INSXRepositories
    {
        private FpolyDBContext context;
        public NSXRepositories()
        {
            context = new FpolyDBContext();
        }
        //public bool Add(string ma, string ten)
        //{
        //   Nsx thao = new Nsx();
        //    thao.Ma = ma;
        //    thao.Ten = ten;
        //    context.Nsxes.Add(thao);
        //    context.SaveChanges();
        //    return true;
        //}

        public bool Add(Nsx nsx)
        {
            if (nsx == null) return false;
            context.Nsxes.Add(nsx);
            context.SaveChanges();
            return true;
        }

        //public bool Delete(Guid id)
        //{
        //    var thao = context.Nsxes.Find(id);
        //    context.Nsxes.RemoveRange(thao);
        //    context.SaveChanges();
        //    return true;
        //}

        public bool Delete(Nsx nsx)
        {
            if (nsx == null) return false;
            var thao = context.Nsxes.FirstOrDefault(a => a.Id == nsx.Id);

            context.Remove(thao);
            context.SaveChanges();
            return true;
        }

        public List<Nsx> GetAll()
        {
            return context.Nsxes.ToList();
        }

        //public bool Update(Guid id, string ma, string ten)
        //{
        //    var thao = context.Nsxes.Find(id);
        //    thao.Ten = ten;
        //    thao.Ma = ma;
        //    context.Update(thao);
        //    context.SaveChanges();
        //    return true;
        //}

        public bool Update(Nsx nsx)
        {
            if (nsx == null) return false;
            var thao = context.Nsxes.FirstOrDefault(a => a.Id == nsx.Id);
            thao.Ten = nsx.Ten;
            thao.Ma = nsx.Ma;
            context.Update(thao);
            context.SaveChanges();
            return true;
        }
    }
}
