using _1.DAL.DomainClass;

namespace _2.BUS.ViewModels
{
    public class BanHangView
    {
        public GioHang GioHang { get; set; }
        public GioHangChiTiet GioHangChiTiet { get; set; }
        public KhachHang KhachHang { get; set; }
        public HoaDon HoaDon { get; set; }
        public HoaDonChiTiet HoaDonChiTiet { get; set; }
    }
}
