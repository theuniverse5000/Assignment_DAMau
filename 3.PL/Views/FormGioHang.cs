using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;
using System.Data;

namespace _3.PL.Views
{
    public partial class FormGioHang : Form
    {
        IKhachHangService _khachHangService;
        IGioHang_HoaDonService _giohang_HoaDonService;
        IQLCuaHangService _QLCuaHangService;
        Guid GetIDgiohang { get; set; }
        public FormGioHang()
        {
            InitializeComponent();
            _khachHangService = new KhachHangService();
            _giohang_HoaDonService = new GioHang_HoaDonService();
            _QLCuaHangService = new QLCuaHangService();
            LoadCombobox();
        }
        public void LoadGioHang(List<BanHangView> listgh)
        {
            dtg_giohang.Rows.Clear();
            int stt = 0;
            dtg_giohang.ColumnCount = 14;
            dtg_giohang.Columns[0].Name = "STT";
            dtg_giohang.Columns[1].Name = "ID";
            dtg_giohang.Columns[1].Visible = false;
            dtg_giohang.Columns[2].Name = "ID Khách Hàng";
            dtg_giohang.Columns[2].Visible = false;
            dtg_giohang.Columns[3].Name = "SĐT khách hàng";
            dtg_giohang.Columns[4].Name = "ID Nhân Viên";
            dtg_giohang.Columns[4].Visible = false;
            dtg_giohang.Columns[5].Name = "Mã nhân viên";
            dtg_giohang.Columns[6].Name = "Mã giỏ hàng";
            dtg_giohang.Columns[7].Name = "Ngày tạo";
            dtg_giohang.Columns[8].Name = "Ngày thanh toán";
            dtg_giohang.Columns[9].Name = "Tên người nhận";
            dtg_giohang.Columns[10].Name = "Địa chỉ";
            dtg_giohang.Columns[11].Name = "SĐT";
            dtg_giohang.Columns[12].Name = "Tình trạng";
            dtg_giohang.Columns[12].Visible = false;
            dtg_giohang.Columns[13].Name = "Tình trạng";

            string tinhtrangs;

            foreach (var s in listgh)
            {
                string sdtkh = _khachHangService.GetKhachHang().FirstOrDefault(a => a.Id == s.GioHang.IdKh).Sdt;
                string manv = _QLCuaHangService.GetNhanVien().FirstOrDefault(a => a.Id == s.GioHang.IdNv).Ma;
                stt++;
                if (s.GioHang.TinhTrang == 1)
                {
                    tinhtrangs = "Đã thanh toán";
                }
                else
                {
                    tinhtrangs = "Chưa thanh toán";
                }
                dtg_giohang.Rows.Add(stt, s.GioHang.Id, s.GioHang.IdKh, sdtkh, s.GioHang.IdNv, manv, s.GioHang.Ma, s.GioHang.NgayTao, s.GioHang.NgayThanhToan,
                    s.GioHang.TenNguoiNhan, s.GioHang.DiaChi, s.GioHang.Sdt, s.GioHang.TinhTrang, tinhtrangs);
            }


        }
        public void LoadCombobox()
        {
            //  load lên combobox
            var getsdtkh = from a in _khachHangService.GetKhachHang()
                           select a.Sdt;
            foreach (var s in getsdtkh)
            {
                cbb_idkhachhang.Items.Add(s);
            }
            //  Lấy ma nhân viên load lên combobox
            var getmanv = from a in _QLCuaHangService.GetNhanVien()
                          select a.Ma;
            foreach (var s in getmanv)
            {
                cbb_idnhanvien.Items.Add(s);
            }
        }
        private void FormGioHang_Load(object sender, EventArgs e)
        {
            LoadGioHang(_giohang_HoaDonService.GetGioHang());
        }

        private void btn_themgiohang_Click(object sender, EventArgs e)
        {
            var thao = new BanHangView();
            thao.GioHang = new _1.DAL.DomainClass.GioHang();
            thao.GioHang.IdKh = cbb_idkhachhang.Text != null ? _khachHangService.GetKhachHang().FirstOrDefault(a => a.Sdt == cbb_idkhachhang.Text).Id : null;
            thao.GioHang.IdNv = cbb_idnhanvien.Text != null ? _QLCuaHangService.GetNhanVien().FirstOrDefault(a => a.Ma == cbb_idnhanvien.Text).Id : null;
            thao.GioHang.Ma = tbx_magh.Text;
            thao.GioHang.NgayTao = Convert.ToDateTime(dtp_ngaytao.Value.ToString());
            thao.GioHang.NgayThanhToan = Convert.ToDateTime(dtp_ngaythanhtoan.Value.ToString());
            thao.GioHang.TenNguoiNhan = tbx_tennguoinhan.Text;
            thao.GioHang.DiaChi = tbx_diachinguoinhan.Text;
            thao.GioHang.Sdt = tbx_sdtnguoinhan.Text;
            thao.GioHang.TinhTrang = rbt_0.Checked ? 0 : 1;
            if (_giohang_HoaDonService.CheckMaGioHang(tbx_magh.Text))
            {
                MessageBox.Show("Mã đã tồn tại", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                _giohang_HoaDonService.AddGioHang(thao);
                LoadGioHang(_giohang_HoaDonService.GetGioHang());
            }
        }

        private void btn_suagiohang_Click(object sender, EventArgs e)
        {
            var thao = new BanHangView();
            thao.GioHang = new _1.DAL.DomainClass.GioHang();
            thao.GioHang.Id = GetIDgiohang;
            thao.GioHang.IdKh = cbb_idkhachhang.Text != null ? _khachHangService.GetKhachHang().FirstOrDefault(a => a.Sdt == cbb_idkhachhang.Text).Id : null;
            thao.GioHang.IdNv = cbb_idnhanvien.Text != null ? _QLCuaHangService.GetNhanVien().FirstOrDefault(a => a.Ma == cbb_idnhanvien.Text).Id : null;
            thao.GioHang.Ma = tbx_magh.Text;
            thao.GioHang.NgayTao = Convert.ToDateTime(dtp_ngaytao.Value.ToString());
            thao.GioHang.NgayThanhToan = Convert.ToDateTime(dtp_ngaythanhtoan.Value.ToString());
            thao.GioHang.TenNguoiNhan = tbx_tennguoinhan.Text;
            thao.GioHang.DiaChi = tbx_diachinguoinhan.Text;
            thao.GioHang.Sdt = tbx_sdtnguoinhan.Text;
            thao.GioHang.TinhTrang = rbt_0.Checked ? 0 : 1;

            _giohang_HoaDonService.UpdateGioHang(thao);
            LoadGioHang(_giohang_HoaDonService.GetGioHang());

        }

        private void btn_xoagiohang_Click(object sender, EventArgs e)
        {
            var thao = new BanHangView();
            thao.GioHang = new _1.DAL.DomainClass.GioHang();
            thao.GioHang.Id = GetIDgiohang;
            _giohang_HoaDonService.DeleteGioHang(thao);
            LoadGioHang(_giohang_HoaDonService.GetGioHang());
        }

        private void dtg_giohang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetIDgiohang = Guid.Parse(dtg_giohang.CurrentRow.Cells[1].Value.ToString());
            Guid idkhachhang = Guid.Parse(dtg_giohang.CurrentRow.Cells[2].Value.ToString());
            cbb_idkhachhang.Text = _khachHangService.GetKhachHang().FirstOrDefault(a => a.Id == idkhachhang).Sdt;
            Guid idnhanvien = Guid.Parse(dtg_giohang.CurrentRow.Cells[4].Value.ToString());
            cbb_idnhanvien.Text = _QLCuaHangService.GetNhanVien().FirstOrDefault(a => a.Id == idnhanvien).Ma;
            tbx_magh.Text = dtg_giohang.CurrentRow.Cells[6].Value.ToString();
            dtp_ngaytao.Value = Convert.ToDateTime(dtg_giohang.CurrentRow.Cells[7].Value.ToString());
            dtp_ngaythanhtoan.Value = Convert.ToDateTime(dtg_giohang.CurrentRow.Cells[8].Value.ToString());
            tbx_tennguoinhan.Text = dtg_giohang.CurrentRow.Cells[9].Value.ToString();
            tbx_diachinguoinhan.Text = dtg_giohang.CurrentRow.Cells[10].Value.ToString();
            tbx_sdtnguoinhan.Text = dtg_giohang.CurrentRow.Cells[11].Value.ToString();
            int tinht = Convert.ToInt32(dtg_giohang.CurrentRow.Cells[12].Value.ToString());
            if (tinht == 1)
                rbt_1.Checked = true;
            else if (tinht == 0)
                rbt_0.Checked = true;
            else
            {
                rbt_0.Checked = false;
                rbt_1.Checked = false;
            }
        }
    }
}
