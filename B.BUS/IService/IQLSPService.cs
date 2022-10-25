using _2.BUS.ViewModels;

namespace _2.BUS.IService
{
    public interface IQLSPService
    {

        // Lấy 1 list show ra form index
     //   List<SanPhamView> GetAll();
        /// <summary>
        /// Cấu trúc 1 bảng : thêm, sửa ,xóa,đọc dữ liệu,check mã ,.....
        /// </summary>
        /// <param name="spv"></param>
        /// <returns></returns>
        // CRUD Chi tiết sản phẩm      
        string AddCTSP(ChiTietSanPhamView ctspv);
        string UpdateCTSP(ChiTietSanPhamView ctspv);
        string DeleteCTSP(ChiTietSanPhamView ctspv);
        List<ChiTietSanPhamView> GetCTSP();
        // CRUD sản phẩm
        string AddSP(SanPhamView spv);
        string UpdateSP(SanPhamView spv);
        string DeleteSP(SanPhamView spv);
        List<SanPhamView> GetSP();
        bool CheckMaSP(string cmasp);
        // CRUD dòng sản phẩm
        string AddDSP(DongSanPhamView dspv);
        string UpdateDSP(DongSanPhamView dspv);
        string DeleteDSP(DongSanPhamView dspv);
        List<DongSanPhamView> GetDSP();
        bool CheckDSP(string cmadsp);
        // CRUD Nhà sản xuất
        string AddNSX(NhaSanXuatView nsxv);
        string UpdateNSX(NhaSanXuatView nsxv);
        string DeleteNSX(NhaSanXuatView nsxv);
        List<NhaSanXuatView> GetNSX();
        bool CheckNSX(string cmansx);
        // CRUD Màu sắc
        string AddMS(MauSacView msv);
        string UpdateMS(MauSacView msv);
        string DeleteMS(MauSacView msv);
        List<MauSacView> GetMauSac();
        public bool CheckMS(string cmams);


    }
}
