namespace _2.BUS.ViewModels
{
    public class ChiTietSanPhamView
    {
        public Guid Id { get; set; }

        public Guid? IdSp { get; set; }
        public Guid? IdNsx { get; set; }
        public Guid? IdMauSac { get; set; }

        public Guid? IdDongSp { get; set; }

        public int? NamBh { get; set; }

        public string? MoTa { get; set; }
        public int? SoLuongTon { get; set; }

        public decimal? GiaNhap { get; set; }

        public decimal? GiaBan { get; set; }
        public string? TenSanPham { get; set; }
        public string? TenNhaSanXuat { get; set; }
        public string? TenMauSac { get; set; }
        public string? TenDongSanPham { get; set; }

    }
}
