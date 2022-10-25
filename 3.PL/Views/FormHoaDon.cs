using _1.DAL.DomainClass;
using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class FormHoaDon : Form
    {
        IKhachHangService _khachHangService;
        IGioHang_HoaDonService _giohang_HoaDonService;
        IQLCuaHangService _QLCuaHangService;
        Guid GetIDhoadon { get; set; }
        public FormHoaDon()
        {
            InitializeComponent();
            _khachHangService = new KhachHangService();
            _giohang_HoaDonService = new GioHang_HoaDonService();
            _QLCuaHangService = new QLCuaHangService();
            LoadCombobox();
        }
        public void LoadHoaDon(List<BanHangView> listhoadon)
        {
            dtg_hoadon.Rows.Clear();
            int stt = 0;
            string tinhtrangs;
            dtg_hoadon.ColumnCount = 16;
            dtg_hoadon.Columns[0].Name = "STT";
            dtg_hoadon.Columns[1].Name = "ID";
            dtg_hoadon.Columns[1].Visible = false;
            dtg_hoadon.Columns[2].Name = "ID Khách Hàng";
            dtg_hoadon.Columns[2].Visible = false;
            dtg_hoadon.Columns[3].Name = "SĐT khách hàng";
            dtg_hoadon.Columns[4].Name = "ID Nhân Viên";
            dtg_hoadon.Columns[4].Visible = false;
            dtg_hoadon.Columns[5].Name = "Mã nhân viên";
            dtg_hoadon.Columns[6].Name = "Mã hóa đơn";
            dtg_hoadon.Columns[7].Name = "Ngày tạo";
            dtg_hoadon.Columns[8].Name = "Ngày thanh toán";
            dtg_hoadon.Columns[9].Name = "Ngày ship";
            dtg_hoadon.Columns[10].Name = "Ngày nhận";
            dtg_hoadon.Columns[11].Name = "Tình trạng";
            dtg_hoadon.Columns[12].Name = "Tình trạng";
            dtg_hoadon.Columns[13].Name = "Tên người nhận";
            dtg_hoadon.Columns[14].Name = "Địa chỉ";
            dtg_hoadon.Columns[15].Name = "Sđt";
            foreach (var s in listhoadon)
            {
                stt++;
                string getsdtkh = _khachHangService.GetKhachHang().FirstOrDefault(a => a.Id == s.HoaDon.IdKh).Sdt;
                string getmanv = _QLCuaHangService.GetNhanVien().FirstOrDefault(a => a.Id == s.HoaDon.IdNv).Ma;
                if (s.HoaDon.TinhTrang == 1)
                    tinhtrangs = "Đã thanh toán";
                else if (s.HoaDon.TinhTrang == 0)
                    tinhtrangs = "Chưa thanh toán";
                else
                    tinhtrangs = null;
                dtg_hoadon.Rows.Add(stt, s.HoaDon.Id, s.HoaDon.IdKh, getsdtkh, s.HoaDon.IdNv, getmanv, s.HoaDon.Ma, s.HoaDon.NgayTao, s.HoaDon.NgayThanhToan, s.HoaDon.NgayShip, s.HoaDon.NgayNhan,
                    s.HoaDon.TinhTrang, tinhtrangs, s.HoaDon.TenNguoiNhan, s.HoaDon.DiaChi, s.HoaDon.Sdt);
            }

        }
        public void LoadCombobox()
        {
            // load lên combobox
            var getsdtkh = from a in _khachHangService.GetKhachHang()
                           select a.Sdt;
            foreach (var s in getsdtkh)
            {
                cbb_idkhachhang.Items.Add(s);
            }
            //   Lấy id nhân viên load lên combobox
            var getmanv = from a in _QLCuaHangService.GetNhanVien()
                          select a.Ma;
            foreach (var s in getmanv)
            {
                cbb_idnhanvien.Items.Add(s);
            }
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDon(_giohang_HoaDonService.GetHoaDon());
        }

        private void btn_themhoadon_Click(object sender, EventArgs e)
        {
            var thao = new BanHangView();
            thao.HoaDon = new HoaDon();
            thao.HoaDon.IdKh = cbb_idkhachhang.Text != null ? _khachHangService.GetKhachHang().FirstOrDefault(a => a.Sdt == cbb_idkhachhang.Text).Id : null;
            thao.HoaDon.IdNv = cbb_idnhanvien.Text != null ? _QLCuaHangService.GetNhanVien().FirstOrDefault(a => a.Ma == cbb_idnhanvien.Text).Id : null;
            thao.HoaDon.Ma = tbx_mahd.Text;
            thao.HoaDon.NgayTao = Convert.ToDateTime(dtp_ngaytao.Value.ToString());
            thao.HoaDon.NgayThanhToan = Convert.ToDateTime(dtp_ngaythanhtoan.Value.ToString());
            thao.HoaDon.NgayShip = Convert.ToDateTime(dtp_ngayship.Value.ToString());
            thao.HoaDon.NgayNhan = Convert.ToDateTime(dtp_ngaynhan.Value.ToString());
            thao.HoaDon.TinhTrang = rbt_0.Checked ? 0 : 1;
            thao.HoaDon.TenNguoiNhan = tbx_tennguoinhan.Text;
            thao.HoaDon.DiaChi = tbx_diachinguoinhan.Text;
            thao.HoaDon.Sdt = tbx_sdtnguoinhan.Text;
            if (_giohang_HoaDonService.CheckMaHoaDon(tbx_mahd.Text))
            {
                MessageBox.Show("Mã đã tồn tại", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                _giohang_HoaDonService.AddHoaDon(thao);
                LoadHoaDon(_giohang_HoaDonService.GetHoaDon());
            }
        }

        private void btn_suahoadon_Click(object sender, EventArgs e)
        {
            var thao = new BanHangView();
            thao.HoaDon = new HoaDon();
            thao.HoaDon.Id = GetIDhoadon;
            thao.HoaDon.IdKh = cbb_idkhachhang.Text != null ? _khachHangService.GetKhachHang().FirstOrDefault(a => a.Sdt == cbb_idkhachhang.Text).Id : null;
            thao.HoaDon.IdNv = cbb_idnhanvien.Text != null ? _QLCuaHangService.GetNhanVien().FirstOrDefault(a => a.Ma == cbb_idnhanvien.Text).Id : null;
            thao.HoaDon.Ma = tbx_mahd.Text;
            thao.HoaDon.NgayTao = Convert.ToDateTime(dtp_ngaytao.Value.ToString());
            thao.HoaDon.NgayThanhToan = Convert.ToDateTime(dtp_ngaythanhtoan.Value.ToString());
            thao.HoaDon.NgayShip = Convert.ToDateTime(dtp_ngayship.Value.ToString());
            thao.HoaDon.NgayNhan = Convert.ToDateTime(dtp_ngaynhan.Value.ToString());
            thao.HoaDon.TinhTrang = rbt_0.Checked ? 0 : 1;
            thao.HoaDon.TenNguoiNhan = tbx_tennguoinhan.Text;
            thao.HoaDon.DiaChi = tbx_diachinguoinhan.Text;
            thao.HoaDon.Sdt = tbx_sdtnguoinhan.Text;
            _giohang_HoaDonService.UpdateHoaDon(thao);
            LoadHoaDon(_giohang_HoaDonService.GetHoaDon());
        }

        private void btn_xoahoadon_Click(object sender, EventArgs e)
        {
            var thao = new BanHangView();
            thao.HoaDon = new HoaDon();
            thao.HoaDon.Id = GetIDhoadon;
            _giohang_HoaDonService.DeleteHoaDon(thao);
            LoadHoaDon(_giohang_HoaDonService.GetHoaDon());
        }

        private void dtg_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetIDhoadon = Guid.Parse(dtg_hoadon.CurrentRow.Cells[1].Value.ToString());
            Guid idkhs = Guid.Parse(dtg_hoadon.CurrentRow.Cells[2].Value.ToString());
            cbb_idkhachhang.Text = _khachHangService.GetKhachHang().FirstOrDefault(a => a.Id == idkhs).Sdt;
            Guid idnvs = Guid.Parse(dtg_hoadon.CurrentRow.Cells[4].Value.ToString());
            cbb_idnhanvien.Text = _QLCuaHangService.GetNhanVien().FirstOrDefault(a => a.Id == idnvs).Ma;
            tbx_mahd.Text = dtg_hoadon.CurrentRow.Cells[6].Value.ToString();
            dtp_ngaytao.Value = Convert.ToDateTime(dtg_hoadon.CurrentRow.Cells[7].Value.ToString());
            dtp_ngaythanhtoan.Value = Convert.ToDateTime(dtg_hoadon.CurrentRow.Cells[8].Value.ToString());
            dtp_ngayship.Value = Convert.ToDateTime(dtg_hoadon.CurrentRow.Cells[9].Value.ToString());
            dtp_ngaynhan.Value = Convert.ToDateTime(dtg_hoadon.CurrentRow.Cells[10].Value.ToString());
            tbx_tennguoinhan.Text = dtg_hoadon.CurrentRow.Cells[13].Value.ToString();
            tbx_diachinguoinhan.Text = dtg_hoadon.CurrentRow.Cells[14].Value.ToString();
            tbx_sdtnguoinhan.Text = dtg_hoadon.CurrentRow.Cells[15].Value.ToString();
            int ttt = Convert.ToInt32(dtg_hoadon.CurrentRow.Cells[11].Value.ToString());
            if (ttt == 1)
                rbt_1.Checked = true;
            else if (ttt == 0)
                rbt_0.Checked = true;
            else
            {
                rbt_0.Checked = false;
                rbt_1.Checked = false;
            }
        }
    }
}
