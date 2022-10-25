using _1.DAL.DomainClass;
using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IQLCuaHangService
    {
        bool CheckLogin(string username, string password);
        string AddCuaHang(CuaHangView chv);
        string UpdateCuaHang(CuaHangView chv);
        string DeleteCuaHang(CuaHangView chv);
        List<CuaHangView> GetCuaHang();
        bool CheckMaCuaHang(string cmach);
        string AddChucVu(ChucVuView cvv);
        string UpdateChucVu(ChucVuView cvv);
        string DeleteChucVu(ChucVuView cvv);
        List<ChucVuView> GetChucVu();
        bool CheckMaChucVu(string cmacv);
        string AddNhanVien(NhanVienView nvv);
        string UpdateNhanVien(NhanVienView nvv);
        string DeleteNhanVien(NhanVienView nvv);
        List<NhanVienView> GetNhanVien();
        bool CheckMaNhanVien(string cmanv);
     //  List<CuaHangView> GetAll();
      //  List<NhanVienView> GetNVCV();
    }
}
