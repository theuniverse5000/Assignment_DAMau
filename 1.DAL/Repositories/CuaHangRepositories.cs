using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class CuaHangRepositories : ICuaHangRepositories
    {
        private FpolyDBContext context;
        public CuaHangRepositories()
        {
            context = new FpolyDBContext();
        }
        public bool Add(CuaHang ch)
        {
            if (ch == null) return false;
            //   ch.Id = Guid.NewGuid();// Tự động zen khóa chính
            context.CuaHangs.Add(ch);
            context.SaveChanges();
            return true;
        }
        public bool Update(CuaHang ch)
        {
            if (ch == null) return false;
            var tempt = context.CuaHangs.FirstOrDefault(a => a.Id == ch.Id);
            tempt.Ma = ch.Ma;
            tempt.Ten = ch.Ten;
            tempt.DiaChi = ch.DiaChi;
            tempt.ThanhPho = ch.ThanhPho;
            tempt.QuocGia = ch.QuocGia;
            context.Update(tempt);
            context.SaveChanges();
            return true;
        }
        public bool Delete(CuaHang ch)
        {
            if (ch == null) return false;
            var tempt = context.CuaHangs.FirstOrDefault(a => a.Id == ch.Id);
            context.Remove(tempt);
            context.SaveChanges();
            return true;
        }

        public List<CuaHang> GetAll()
        {
            return context.CuaHangs.ToList();
        }
    }
}
