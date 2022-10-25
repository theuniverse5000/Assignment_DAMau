using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class KhachHangRepositories : IKhachHangRepositories
    {
        private FpolyDBContext context;
        public KhachHangRepositories()
        {
            context = new FpolyDBContext();
        }
        public bool Add(KhachHang kh)
        {
            if (kh == null) return false;
            context.KhachHangs.Add(kh);
            context.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang kh)
        {
            if (kh == null) return false;
            var thao = context.KhachHangs.FirstOrDefault(a => a.Id == kh.Id);
            //var thao = context.KhachHangs.Find(kh.Id);
            context.Remove(thao);
            context.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return context.KhachHangs.ToList();
        }
        public bool Update(KhachHang kh)
        {
            if (kh == null) return false;

            var thao = context.KhachHangs.FirstOrDefault(a => a.Id == kh.Id);
            thao.Ma = kh.Ma;
            thao.Ten = kh.Ten;
            thao.TenDem = kh.TenDem;
            thao.Ho = kh.Ho;
            thao.NgaySinh = kh.NgaySinh;
            thao.DiaChi = kh.DiaChi;
            thao.Sdt = kh.Sdt;
            thao.MatKhau = kh.MatKhau;
            thao.ThanhPho = kh.ThanhPho;
            thao.QuocGia = kh.QuocGia;
            context.Update(thao);
            context.SaveChanges();
            return true;
        }
    }
}
