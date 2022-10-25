using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class VNINDEX : Form
    {
        IQLSPService _qLSPService;
        IQLCuaHangService _QLCuaHangService;
        public VNINDEX()
        {
            InitializeComponent();
            _qLSPService = new QLSPService();
            _QLCuaHangService = new QLCuaHangService();
        }
        //public void LoadDataSanPhamView(List<SanPhamView> list)
        //{
        //    int stt = 0;
        //    dtg_quanlysanpham.Rows.Clear();
        //    dtg_quanlysanpham.ColumnCount = 10;
        //    dtg_quanlysanpham.Columns[0].Name = "STT";
        //    dtg_quanlysanpham.Columns[1].Name = "Tên sản phẩm";
        //    dtg_quanlysanpham.Columns[2].Name = "Nhà sản xuất";
        //    dtg_quanlysanpham.Columns[3].Name = "Màu sắc";
        //    dtg_quanlysanpham.Columns[4].Name = "Dòng sản phẩm";
        //    dtg_quanlysanpham.Columns[5].Name = "Năm bảo hành";
        //    dtg_quanlysanpham.Columns[6].Name = "Mô tả";
        //    dtg_quanlysanpham.Columns[7].Name = "Số lượng tồn";
        //    dtg_quanlysanpham.Columns[8].Name = "Giá nhập";
        //    dtg_quanlysanpham.Columns[9].Name = "Giá bán";
        //    foreach (var t in list)
        //    {
        //        stt++;
        //        dtg_quanlysanpham.Rows.Add(stt, t.SanPham.Ten, t.Nsx.Ten, t.MauSac.Ten, t.DongSp.Ten, t.ChiTietSp.NamBh, t.ChiTietSp.MoTa, t.ChiTietSp.SoLuongTon, t.ChiTietSp.GiaNhap, t.ChiTietSp.GiaBan);
        //    }

        //}
        public void LoadDataCuaHangView(List<CuaHangView> list)
        {
            int stt = 0;
            dtg_showcuahang.Rows.Clear();
            dtg_showcuahang.ColumnCount = 5;
            dtg_showcuahang.Columns[0].Name = "STT";
            dtg_showcuahang.Columns[1].Name = "Tên cửa hàng";
            dtg_showcuahang.Columns[2].Name = "Địa chỉ";
            dtg_showcuahang.Columns[3].Name = "Chức vụ";
            dtg_showcuahang.Columns[4].Name = "Tên";
            foreach (var s in list)
            {
                stt++;
                dtg_showcuahang.Rows.Add(stt, s.Ten, s.DiaChi, s.Ten, s.Ten);
            }
        }

        private void btn_qlsp_Click(object sender, EventArgs e)
        {
            QuanLySanPham qlsp = new QuanLySanPham();
            qlsp.ShowDialog();
        }

        private void VNINDEX_Load(object sender, EventArgs e)
        {
            //LoadDataSanPhamView(_qLSPService.GetAll());
       //     LoadDataCuaHangView(_QLCuaHangService.GetAll());
        }


      
        private void btn_qlcuahang_Click(object sender, EventArgs e)
        {
            CuaHang_NhanVien chnv = new CuaHang_NhanVien();
            chnv.ShowDialog();
        }

        private void btn_qlkhachhang_Click(object sender, EventArgs e)
        {
            FormKhachHang khv = new FormKhachHang();
            khv.ShowDialog();
        }

        private void btn_qlgiohang_Click(object sender, EventArgs e)
        {
            FormGioHang formGioHang = new FormGioHang();
            formGioHang.ShowDialog();
        }

        private void btn_qlhoadon_Click(object sender, EventArgs e)
        {
            FormHoaDon fhd = new FormHoaDon();
            fhd.ShowDialog();
        }
    }
}
