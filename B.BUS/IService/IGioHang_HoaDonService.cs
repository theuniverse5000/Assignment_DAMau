using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IGioHang_HoaDonService
    {
        string AddGioHang(BanHangView bhv);
        string UpdateGioHang(BanHangView bhv);
        string DeleteGioHang(BanHangView bhv);
        List<BanHangView> GetGioHang();
        bool CheckMaGioHang(string cmagh);
        string AddHoaDon(BanHangView bhv);
        string UpdateHoaDon(BanHangView bhv);
        string DeleteHoaDon(BanHangView bhv);
        List<BanHangView> GetHoaDon();
        bool CheckMaHoaDon(string cmahd);

    }
}
