using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IService;
using _2.BUS.ViewModels;

namespace _2.BUS.Service
{
    public class GioHang_HoaDonService : IGioHang_HoaDonService
    {
        IGioHangRepositories _gioHangRepositories;
        IHoaDonRepositories _hoaDonRepositories;
        public GioHang_HoaDonService()
        {
            _gioHangRepositories = new GioHangRepositories();
            _hoaDonRepositories = new HoaDonRepositories();
        }
        public string AddGioHang(BanHangView bhv)
        {
            var thao = bhv.GioHang;
            if (bhv == null) return "Not";
            if (_gioHangRepositories.Add(thao)) return "OK";
            else return "Not";
        }

        public string AddHoaDon(BanHangView bhv)
        {
            var thao = bhv.HoaDon;
            if (bhv == null) return "Not";
            if (_hoaDonRepositories.Add(thao)) return "OK";
            else return "Not";
        }



        public string DeleteGioHang(BanHangView bhv)
        {
            var thao = bhv.GioHang;
            if (bhv == null) return "Not";
            if (_gioHangRepositories.Delete(thao)) return "OK";
            else return "Not";
        }

        public string DeleteHoaDon(BanHangView bhv)
        {
            var thao = bhv.HoaDon;
            if (bhv == null) return "Not";
            if (_hoaDonRepositories.Delete(thao)) return "OK";
            else return "Not";
        }

        public List<BanHangView> GetGioHang()
        {
            List<BanHangView> listgiohang = new List<BanHangView>();
            listgiohang = (
                from a in _gioHangRepositories.GetAll()
                select new BanHangView()
                {
                    GioHang = a
                }
                ).ToList();
            return listgiohang;
        }

        public List<BanHangView> GetHoaDon()
        {
            List<BanHangView> listhoadon = new List<BanHangView>();
            listhoadon = (
                from a in _hoaDonRepositories.GetAll()
                select new BanHangView()
                {
                    HoaDon = a
                }
                ).ToList();
            return listhoadon;
        }

        public string UpdateGioHang(BanHangView bhv)
        {
            var thao = bhv.GioHang;
            if (bhv == null) return "Not";
            if (_gioHangRepositories.Update(thao)) return "OK";
            else return "Not";
        }

        public string UpdateHoaDon(BanHangView bhv)
        {
            var thao = bhv.HoaDon;
            if (bhv == null) return "Not";
            if (_hoaDonRepositories.Update(thao)) return "OK";
            else return "Not";
        }
        public bool CheckMaGioHang(string cmagh)
        {
            var thao = GetGioHang().FirstOrDefault(a => a.GioHang.Ma == cmagh);
            if (thao == null) return false;
            else return true;
        }

        public bool CheckMaHoaDon(string cmahd)
        {
            // khai báo var 1 đối tượng , tìm 1 hóa đơn điều kiện là mã hóa đơn giống với chuỗi kí tự truyền vào
            // xong gán hóa đơn đó cho tối tượng đã khai báo
            // nếu thao == null - tức là không tồn tại mã hóa đơn giống với chuỗi kí tự truyền vào
            // phương thức kiểm tra tồn tại mã hóa đơn hay không nếu trả về false => mã không tồn tại
            // trả về true => mã có tồn tại
            // có thể kiểm .count để đếm xem tồn tại bn lần....
            var thao = GetHoaDon().FirstOrDefault(a => a.HoaDon.Ma == cmahd);
            if (thao == null) return false;
            else return true;
        }
    }
}
