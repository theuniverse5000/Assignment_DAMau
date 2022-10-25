using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class QLCuaHangService : IQLCuaHangService
    {
        private ICuaHangRepositories cuahangr;
        private IChucVuRepositories chucvur;
        private INhanVienRepositories nhanvienr;
        public QLCuaHangService()

        {

            cuahangr = new CuaHangRepositories();
            chucvur = new ChucVuRepositories();
            nhanvienr = new NhanVienRepositories();
        }
        public bool CheckLogin(string username, string password)
        {
            var a = nhanvienr.GetAll();  // gán cho a 1 list nhân viên
            var thao = a.FirstOrDefault(a => a.Sdt == username && a.MatKhau == password);// tìm một nhan vien đúng có check hoa thường
            if (thao != null) return true;
            else return false;
        }
        public string AddChucVu(ChucVuView cvv)
        {
            if (cvv == null) return "Thất bại";
            var thao = new ChucVu();
            thao.Ma = cvv.Ma;
            thao.Ten = cvv.Ten;
            if (chucvur.Add(thao)) return "Thành công";
            else return "Thất bại";
        }

        public string AddCuaHang(CuaHangView chv)
        {
            if (chv == null) return "Thất bại";
            var thao = new CuaHang();
            thao.Ma = chv.Ma;
            thao.Ten = chv.Ten;
            thao.DiaChi = chv.DiaChi;
            thao.ThanhPho = chv.ThanhPho;
            thao.QuocGia = chv.QuocGia;
            if (cuahangr.Add(thao)) return "Thành công";
            else return "Thất bại";
        }

        public string AddNhanVien(NhanVienView nvv)
        {
            if (nvv == null) return "Thất bại";
            var thao = new NhanVien();
            thao.Ma = nvv.Ma;
            thao.Ten = nvv.Ten;
            thao.TenDem = nvv.TenDem;
            thao.Ho = nvv.Ho;
            thao.GioiTinh = nvv.GioiTinh;
            thao.NgaySinh = nvv.NgaySinh;
            thao.DiaChi = nvv.DiaChi;
            thao.Sdt = nvv.Sdt;
            thao.MatKhau = nvv.MatKhau;
            thao.IdCv = nvv.IdCv;
            thao.IdCh = nvv.IdCh;
            thao.TrangThai = nvv.TrangThai;
            if (nhanvienr.Add(thao)) return "Thành công";
            else return "Thất bại";
        }
        public string DeleteChucVu(ChucVuView cvv)
        {
            if (cvv == null) return "Thất bại";
            var thao = new ChucVu();
            thao.Id = cvv.Id;
            if (chucvur.Delete(thao)) return "Thành công";
            else return "Thất bại";
        }

        public string DeleteCuaHang(CuaHangView chv)
        {
            if (chv == null) return "Thất bại";
            var thao = new CuaHang();
            thao.Id = chv.Id;
            if (cuahangr.Delete(thao)) return "Thành công";
            else return "Thất bại"; ;
        }

        public string DeleteNhanVien(NhanVienView nvv)
        {
            if (nvv == null) return "Thất bại";
            var thao = new NhanVien();
            thao.Id = nvv.Id;
            if (nhanvienr.Delete(thao)) return "Thành công";
            else return "Thất bại";
        }
        public List<ChucVuView> GetChucVu()
        {
            List<ChucVuView> listchucvu = new List<ChucVuView>();
            listchucvu = (
                from a in chucvur.GetAll()
                select new ChucVuView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten
                }
                ).ToList();
            return listchucvu;
        }

        public List<CuaHangView> GetCuaHang()
        {
            List<CuaHangView> listcuahang = new List<CuaHangView>();
            listcuahang = (
                from a in cuahangr.GetAll()
                select new CuaHangView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    DiaChi = a.DiaChi,
                    ThanhPho = a.ThanhPho,
                    QuocGia = a.QuocGia
                }
                ).ToList();
            return listcuahang;
        }

        public List<NhanVienView> GetNhanVien()
        {

            List<NhanVienView> listnhanvien = new List<NhanVienView>();
            listnhanvien = (
                from a in nhanvienr.GetAll()
                join b in chucvur.GetAll() on a.IdCv equals b.Id
                join c in cuahangr.GetAll() on a.IdCh equals c.Id
                select new NhanVienView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TenDem = a.TenDem,
                    Ho = a.Ho,
                    GioiTinh = a.GioiTinh,
                    NgaySinh = a.NgaySinh,
                    DiaChi = a.DiaChi,
                    Sdt = a.Sdt,
                    MatKhau = a.MatKhau,
                    TenChucVu = b.Ten,
                    TenCuaHang = c.Ten,
                    IdCv = b.Id,
                    IdCh = c.Id,
                    TrangThai = a.TrangThai,
                    TrangThaiOn = a.TrangThai == 1 ? "ON" : "OFF"

                }
                ).ToList();
            return listnhanvien;
        }

        public string UpdateChucVu(ChucVuView cvv)
        {
            if (cvv == null) return "Thất bại";
            var thao = new ChucVu();
            thao.Id = cvv.Id;
            thao.Ma = cvv.Ma;
            thao.Ten = cvv.Ten;
            if (chucvur.Update(thao)) return "Thành công";
            else return "Thất bại";
        }

        public string UpdateCuaHang(CuaHangView chv)
        {
            if (chv == null) return "Thất bại";
            var thao = new CuaHang();
            thao.Id = chv.Id;
            thao.Ma = chv.Ma;
            thao.Ten = chv.Ten;
            thao.DiaChi = chv.DiaChi;
            thao.ThanhPho = chv.ThanhPho;
            thao.QuocGia = chv.QuocGia;
            if (cuahangr.Update(thao)) return "Thành công";
            else return "Thất bại";
        }

        public string UpdateNhanVien(NhanVienView nvv)
        {
            if (nvv == null) return "Thất bại";
            var thao = new NhanVien();
            thao.Id = nvv.Id;
            thao.Ma = nvv.Ma;
            thao.Ten = nvv.Ten;
            thao.TenDem = nvv.TenDem;
            thao.Ho = nvv.Ho;
            thao.GioiTinh = nvv.GioiTinh;
            thao.NgaySinh = nvv.NgaySinh;
            thao.DiaChi = nvv.DiaChi;
            thao.Sdt = nvv.Sdt;
            thao.MatKhau = nvv.MatKhau;
            thao.IdCv = nvv.IdCv;
            thao.IdCh = nvv.IdCh;
            thao.TrangThai = nvv.TrangThai;
            if (nhanvienr.Update(thao)) return "Thành công";
            else return "Thất bại";
        }

        //public List<CuaHangView> GetAll()
        //{
        //    List<CuaHangView> listcuahangview = new List<CuaHangView>();
        //    listcuahangview = (
        //        from a in nhanvienr.GetAll()
        //        join b in cuahangr.GetAll() on a.IdCh equals b.Id
        //        join c in chucvur.GetAll() on a.IdCv equals c.Id
        //        select new CuaHangView()
        //        {
        //            NhanVien = a,
        //            CuaHang = b,
        //            ChucVu = c
        //        }
        //        ).ToList();
        //    return listcuahangview;
        //}
        public List<NhanVienView> GetNVCV()
        {
            List<NhanVienView> nhanVienViews = new List<NhanVienView>();
            nhanVienViews = (
                from a in nhanvienr.GetAll()
                join b in chucvur.GetAll() on a.IdCv equals b.Id
                join c in cuahangr.GetAll() on a.IdCh equals c.Id
                select new NhanVienView()
                {
                    Ten = a.Ten,
                    TenChucVu = b.Ten,
                    TenCuaHang = c.Ten


                }
                ).ToList();
            return nhanVienViews;
        }

        public bool CheckMaCuaHang(string cmach)
        {
            var thao = GetCuaHang().FirstOrDefault(a => a.Ma == cmach);
            if (thao == null) return false;
            else return true;
        }

        public bool CheckMaChucVu(string cmacv)
        {
            var thao = GetChucVu().FirstOrDefault(a => a.Ma == cmacv);
            if (thao == null) return false;
            else return true;
        }

        public bool CheckMaNhanVien(string cmanv)
        {
            var thao = GetNhanVien().FirstOrDefault(a => a.Ma == cmanv);
            if (thao == null) return false;
            else return true;
            return false;
        }
    }
}
