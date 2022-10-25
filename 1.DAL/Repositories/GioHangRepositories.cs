
using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class GioHangRepositories : IGioHangRepositories
    {
        private FpolyDBContext context;
        public GioHangRepositories()
        {
            context = new FpolyDBContext();
        }
        public bool Add(GioHang gh)
        {
            if (gh == null) return false;
            context.GioHangs.Add(gh);
            context.SaveChanges();
            return true;

        }

        public bool Delete(GioHang gh)
        {
            if (gh == null) return false;
            var thao = context.GioHangs.FirstOrDefault(a => a.Id == gh.Id);
            context.Remove(thao);
            context.SaveChanges();
            return true;
        }

        public List<GioHang> GetAll()
        {
            return context.GioHangs.ToList();
        }

        public bool Update(GioHang gh)
        {
            if (gh == null) return false;
            var thao = context.GioHangs.FirstOrDefault(a => a.Id == gh.Id);
            thao.IdKh = gh.IdKh;
            thao.IdNv = gh.IdNv;
            thao.Ma = gh.Ma;
            thao.NgayTao = gh.NgayTao;
            thao.NgayThanhToan = gh.NgayThanhToan;
            thao.TenNguoiNhan = gh.TenNguoiNhan;
            thao.DiaChi = gh.DiaChi;
            thao.Sdt = gh.Sdt;
            thao.TinhTrang = gh.TinhTrang;
            context.Update(thao);
            context.SaveChanges();
            return true; throw new NotImplementedException();
        }
    }
}
