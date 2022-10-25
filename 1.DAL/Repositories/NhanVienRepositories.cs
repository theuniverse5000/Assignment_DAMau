using _1.DAL.Context;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;

namespace _1.DAL.Repositories
{
    public class NhanVienRepositories : INhanVienRepositories
    {
        private FpolyDBContext context;
        public NhanVienRepositories()
        {
            context = new FpolyDBContext();
        }
        public bool Add(NhanVien nv)
        {
            if (nv == null) return false;
            context.NhanViens.Add(nv);
            context.SaveChanges();
            return true;

        }


        public bool Delete(NhanVien nv)
        {
            if (nv == null) return false;
            var thao = context.NhanViens.FirstOrDefault(a => a.Id == nv.Id);
            context.Remove(thao);
            context.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAll()
        {
            return context.NhanViens.ToList();
        }

        public bool Update(NhanVien nv)
        {
            if (nv == null) return false;
            var thao = context.NhanViens.FirstOrDefault(a => a.Id == nv.Id);
            thao.Ma = nv.Ma;
            thao.Ten = nv.Ten;
            thao.Ho = nv.Ho;
            thao.TenDem = nv.TenDem;
            thao.GioiTinh = nv.GioiTinh;
            thao.NgaySinh = nv.NgaySinh;
            thao.DiaChi = nv.DiaChi;
            thao.Sdt = nv.Sdt;
            thao.MatKhau = nv.MatKhau;
            thao.IdCv = nv.IdCv;
            thao.IdCh = nv.IdCh;
            thao.IdGuiBc = nv.IdGuiBc;
            thao.TrangThai = nv.TrangThai;
            context.Update(thao);
            context.SaveChanges();
            return true;

        }

    }
}
