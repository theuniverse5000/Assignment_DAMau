using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class KhachHangService : IKhachHangService
    {
        IKhachHangRepositories _khachHangRepositories;
        public KhachHangService()
        {
            _khachHangRepositories = new KhachHangRepositories();
        }
        public string Addkh(KhachHangView khv)
        {
            //var thao = bhv.KhachHang;
            //if (bhv == null) return "Not !!!";
            //if (_khachHangRepositories.Add(thao)) return "OK.";
            //else return "Not !!!";
            KhachHang thao = new KhachHang()
            {
                //  Id = khv.Id,
                Ma = khv.Ma,
                Ten = khv.Ten,
                TenDem = khv.TenDem,
                Ho = khv.Ho,
                NgaySinh = khv.NgaySinh,
                Sdt = khv.Sdt,
                DiaChi = khv.DiaChi,
                ThanhPho = khv.ThanhPho,
                QuocGia = khv.QuocGia,
                MatKhau = khv.MatKhau
            };
            if (_khachHangRepositories.Add(thao)) return "OK";
            else return "Not";
        }

        public bool CheckMaKhachHang(string cmakh)
        {
            var thao = GetKhachHang().FirstOrDefault(a => a.Ma == cmakh);
            if (thao == null) return false;
            else return true;
        }

        public string Deletekh(Guid idkhs)
        {
            //var thao = bhv.KhachHang;
            //if (bhv == null) return "Not !!!";
            //if (_khachHangRepositories.Delete(thao)) return "OK.";
            //else return "Not !!!";
            var thao = _khachHangRepositories.GetAll().FirstOrDefault(a => a.Id == idkhs);
            if (_khachHangRepositories.Delete(thao)) return "OK.";
            else return "Not !!!";
        }

        public List<KhachHangView> GetKhachHang()
        {
            List<KhachHangView> listkhachhang = new List<KhachHangView>();
            listkhachhang = (
                from a in _khachHangRepositories.GetAll()
                select new KhachHangView()
                {
                    Id = a.Id,
                    Ma = a.Ma,
                    Ten = a.Ten,
                    TenDem = a.TenDem,
                    Ho = a.Ho,
                    NgaySinh = a.NgaySinh,
                    Sdt = a.Sdt,
                    DiaChi = a.DiaChi,
                    ThanhPho = a.ThanhPho,
                    QuocGia = a.QuocGia,
                    MatKhau = a.MatKhau
                }

                ).ToList();
            return listkhachhang;
        }

        public string Updatekh(KhachHangView khv)
        {
            //var thao = bhv.KhachHang;
            //if (bhv == null) return "Not !!!";
            //if (_khachHangRepositories.Update(thao)) return "OK.";
            //else return "Not !!!";
            KhachHang thao = new KhachHang()
            {
                Id = khv.Id,
                Ma = khv.Ma,
                Ten = khv.Ten,
                TenDem = khv.TenDem,
                Ho = khv.Ho,
                NgaySinh = khv.NgaySinh,
                Sdt = khv.Sdt,
                DiaChi = khv.DiaChi,
                ThanhPho = khv.ThanhPho,
                QuocGia = khv.QuocGia,
                MatKhau = khv.MatKhau
            };
            if (_khachHangRepositories.Update(thao)) return "OK";
            else return "Not";
        }

    }
}
