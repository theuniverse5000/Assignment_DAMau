using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IKhachHangService
    {
       string Addkh(KhachHangView khv);
        string Updatekh(KhachHangView bhv );
       string Deletekh(Guid idkhs);
        List<KhachHangView> GetKhachHang();
        bool CheckMaKhachHang(string cmakh);
    }
}
