using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class ChucVuRepositories : IChucVuRepositories
    {
        private FpolyDBContext context;
        public ChucVuRepositories()
        {
            context = new FpolyDBContext();
        }
        public bool Add(ChucVu cv)
        {
            if (cv == null) return false;
            context.ChucVus.Add(cv);
            context.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu cv)
        {
            if(cv== null) return false;
            var thao = context.ChucVus.FirstOrDefault(a => a.Id == cv.Id);
            context.Remove(thao);
            context.SaveChanges();
            return true;

        }

        public List<ChucVu> GetAll()
        {
            return context.ChucVus.ToList();
        }

        public bool Update(ChucVu cv)
        {
            if (cv == null) return false;
            var thao = context.ChucVus.FirstOrDefault(a => a.Id == cv.Id);
            thao.Ma=cv.Ma;
            thao.Ten = cv.Ten;
            context.Update(thao);
            context.SaveChanges();
            return true;
        }
    }
}
