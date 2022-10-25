using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class CuaHang_NhanVien : Form
    {
        private IQLCuaHangService _QLCuaHangService;
        Guid IDCuaHang { get; set; }
        Guid IDChucVu { get; set; }
        Guid IDNhanVien { get; set; }
        public CuaHang_NhanVien()
        {
            InitializeComponent();
            _QLCuaHangService = new QLCuaHangService();
            LoadCombobox();
        }
        public void LoadCuaHang(List<CuaHangView> listch)
        {
            int stt = 0;
            dtg_showcuahang.Rows.Clear();
            dtg_showcuahang.ColumnCount = 7;
            dtg_showcuahang.Columns[0].Name = "STT";
            dtg_showcuahang.Columns[1].Name = "ID";
            dtg_showcuahang.Columns[1].Visible = false;
            dtg_showcuahang.Columns[2].Name = "Mã";
            dtg_showcuahang.Columns[3].Name = "Tên";
            dtg_showcuahang.Columns[4].Name = "Địa chỉ";
            dtg_showcuahang.Columns[5].Name = "Thành phố";
            dtg_showcuahang.Columns[6].Name = "Quốc gia";
            foreach (var item in listch)
            {
                stt++;
                dtg_showcuahang.Rows.Add(stt, item.Id, item.Ma, item.Ten, item.DiaChi, item.ThanhPho, item.QuocGia);
            }

        }
        public void LoadChucVu(List<ChucVuView> listcv)
        {
            int stt = 0;
            dtg_chucvu.Rows.Clear();
            dtg_chucvu.ColumnCount = 4;
            dtg_chucvu.Columns[0].Name = "STT";
            dtg_chucvu.Columns[1].Name = "ID";
            dtg_chucvu.Columns[1].Visible = false;
            dtg_chucvu.Columns[2].Name = "Mã";
            dtg_chucvu.Columns[3].Name = "Tên";
            foreach (var item in listcv)
            {
                stt++;
                dtg_chucvu.Rows.Add(stt, item.Id, item.Ma, item.Ten);
            }

        }
        public void LoadNhanVien(List<NhanVienView> listnhanvien)
        {
            int stt = 0;
            dtg_nhanvien.Rows.Clear();
            dtg_nhanvien.ColumnCount = 19;
            dtg_nhanvien.Columns[0].Name = "STT";
            dtg_nhanvien.Columns[1].Name = "ID";
            dtg_nhanvien.Columns[1].Visible = false;
            dtg_nhanvien.Columns[2].Name = "Mã";
            dtg_nhanvien.Columns[3].Name = "Tên";
            dtg_nhanvien.Columns[4].Name = "Tên đệm";
            dtg_nhanvien.Columns[5].Name = "Họ";
            dtg_nhanvien.Columns[6].Name = "Giới tính";
            dtg_nhanvien.Columns[7].Name = "Ngày sinh";
            dtg_nhanvien.Columns[8].Name = "Địa chỉ";
            dtg_nhanvien.Columns[9].Name = "SĐT";
            dtg_nhanvien.Columns[10].Name = "Mật khẩu";
            dtg_nhanvien.Columns[11].Name = "ID Cửa Hàng";
            dtg_nhanvien.Columns[11].Visible = false;
            dtg_nhanvien.Columns[12].Name = "Tên";
            dtg_nhanvien.Columns[13].Name = "ID Chức vụ";
            dtg_nhanvien.Columns[13].Visible = false;
            dtg_nhanvien.Columns[14].Name = "Tên chức vụ";
            dtg_nhanvien.Columns[15].Name = "ID Gui BC";
            dtg_nhanvien.Columns[15].Visible = false;
            dtg_nhanvien.Columns[16].Name = "Mã GuiBC";
            dtg_nhanvien.Columns[17].Name = "Trạng thái";
            dtg_nhanvien.Columns[17].Visible = false;
            dtg_nhanvien.Columns[18].Name = "Trạng thái";
            foreach (var t in listnhanvien)
            {
                stt++;
                //string tencuahang = _QLCuaHangService.GetCuaHang().FirstOrDefault(a => a.Id == t.IdCh).Ten;
                //string tenchucvu = _QLCuaHangService.GetChucVu().FirstOrDefault(a => a.Id == t.IdCv).Ten;
                //      string maguibc = _QLCuaHangService.GetNhanVien().FirstOrDefault(a => a.Id == t.IdGuiBc).Ma;
                string maguibc = "";
                //string trangthai;
                //if (t.TrangThai == 1)
                //{
                //    trangthai = "Online";
                //}
                //else if (t.TrangThai == 0)
                //{
                //    trangthai = "Offline";
                //}
                //else
                //{
                //    trangthai = "No infor";
                //}
                //    string maguibc = _QLCuaHangService.GetNhanVien().FirstOrDefault()
                dtg_nhanvien.Rows.Add(stt, t.Id, t.Ma, t.Ten, t.TenDem, t.Ho, t.GioiTinh, t.NgaySinh,
                    t.DiaChi, t.Sdt, t.MatKhau, t.IdCh, t.TenCuaHang, t.IdCv, t.TenChucVu, t.IdGuiBc, maguibc, t.TrangThai, t.TrangThaiOn);
            }


        }
        public void LoadCombobox()
        {
            cbb_idcuahang.Items.Clear();
            cbb_idchucvu.Items.Clear();
            cbb_idguibc.Items.Clear();
            var gettencuahang = from a in _QLCuaHangService.GetCuaHang()
                                select a.Ten;
            foreach (var s in gettencuahang)
            {
                cbb_idcuahang.Items.Add(s);
            }
            var gettenchucvu = from a in _QLCuaHangService.GetChucVu()
                               select a.Ten;
            foreach (var s in gettenchucvu)
            {
                cbb_idchucvu.Items.Add(s);
            }
            var getmanv = from a in _QLCuaHangService.GetNhanVien()
                          select a.Ma;
            //foreach (var s in getmanv)
            //{
            //    cbb_idguibc.Items.Add(s);
            //}
        }
        private void CuaHang_NhanVien_Load(object sender, EventArgs e)
        {
            LoadCuaHang(_QLCuaHangService.GetCuaHang());
            LoadChucVu(_QLCuaHangService.GetChucVu());
            LoadNhanVien(_QLCuaHangService.GetNhanVien());

        }
        private void btn_themch_Click(object sender, EventArgs e)
        {
            var a = new CuaHangView();

            a.Ma = tbx_mach.Text;
            a.Ten = tbx_tench.Text;
            a.DiaChi = tbx_diachich.Text;
            a.ThanhPho = tbx_tpch.Text;
            a.QuocGia = tbx_qgch.Text;
            if (_QLCuaHangService.CheckMaCuaHang(tbx_mach.Text))
            {
                MessageBox.Show("Mã đã tồn tại", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show(_QLCuaHangService.AddCuaHang(a));
                LoadCuaHang(_QLCuaHangService.GetCuaHang());
            }
        }

        private void btn_suach_Click(object sender, EventArgs e)
        {
            var a = new CuaHangView();

            a.Id = IDCuaHang;
            a.Ma = tbx_mach.Text;
            a.Ten = tbx_tench.Text;
            a.DiaChi = tbx_diachich.Text;
            a.ThanhPho = tbx_tpch.Text;
            a.QuocGia = tbx_qgch.Text;
            MessageBox.Show(_QLCuaHangService.UpdateCuaHang(a));
            LoadCuaHang(_QLCuaHangService.GetCuaHang());
        }
        private void btn_xoach_Click(object sender, EventArgs e)
        {
            var a = new CuaHangView();
            a.Id = IDCuaHang;
            MessageBox.Show(_QLCuaHangService.DeleteCuaHang(a));
            LoadCuaHang(_QLCuaHangService.GetCuaHang());
        }
        private void dtg_showcuahang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDCuaHang = Guid.Parse(dtg_showcuahang.CurrentRow.Cells[1].Value.ToString());
            tbx_mach.Text = dtg_showcuahang.CurrentRow.Cells[2].Value.ToString();
            tbx_tench.Text = dtg_showcuahang.CurrentRow.Cells[3].Value.ToString();
            tbx_diachich.Text = dtg_showcuahang.CurrentRow.Cells[4].Value.ToString();
            tbx_tpch.Text = dtg_showcuahang.CurrentRow.Cells[5].Value.ToString();
            tbx_qgch.Text = dtg_showcuahang.CurrentRow.Cells[6].Value.ToString();
        }
        private void btn_themcv_Click(object sender, EventArgs e)
        {
            var a = new ChucVuView();

            a.Ma = tbx_macv.Text;
            a.Ten = tbx_tencv.Text;
            if (_QLCuaHangService.CheckMaChucVu(tbx_macv.Text))
            {
                MessageBox.Show("Mã đã tồn tại", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                _QLCuaHangService.AddChucVu(a);
                LoadChucVu(_QLCuaHangService.GetChucVu());
            }
        }
        private void btn_suacv_Click(object sender, EventArgs e)
        {
            var a = new ChucVuView();
            a.Id = IDChucVu;
            a.Ma = tbx_macv.Text;
            a.Ten = tbx_tencv.Text;
            _QLCuaHangService.UpdateChucVu(a);
            LoadChucVu(_QLCuaHangService.GetChucVu());

        }

        private void btn_xoacv_Click(object sender, EventArgs e)
        {
            var a = new ChucVuView();
            a.Id = IDChucVu;
            _QLCuaHangService.DeleteChucVu(a);
            LoadChucVu(_QLCuaHangService.GetChucVu());
        }

        private void dtg_chucvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDChucVu = Guid.Parse(dtg_chucvu.CurrentRow.Cells[1].Value.ToString());
            tbx_macv.Text = dtg_chucvu.CurrentRow.Cells[2].Value.ToString();
            tbx_tencv.Text = dtg_chucvu.CurrentRow.Cells[3].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_themnv_Click(object sender, EventArgs e)
        {
            NhanVienView thao = new NhanVienView();
            thao.Ma = tbx_manhanvien.Text;
            thao.Ten = tbx_tennv.Text;
            thao.TenDem = tbx_tendemnv.Text;
            thao.Ho = tbx_honv.Text;
            thao.GioiTinh = tbx_gioitinh.Text;
            thao.NgaySinh = Convert.ToDateTime(dtp_ngaysinhnv.Value.ToString("MM/dd/yyyy"));
            thao.DiaChi = tbx_diachinv.Text;
            thao.Sdt = tbx_sdtnv.Text;
            thao.MatKhau = tbx_matkhaunv.Text;
            thao.IdCh = cbb_idcuahang.Text != null ? _QLCuaHangService.GetCuaHang().FirstOrDefault(a => a.Ten == cbb_idcuahang.Text).Id : null;
            thao.IdCv = cbb_idchucvu.Text != null ? _QLCuaHangService.GetChucVu().FirstOrDefault(a => a.Ten == cbb_idchucvu.Text).Id : null;
            //     thao.IdGuiBc = cbb_idguibc.Text != null ? _QLCuaHangService.GetNhanVien().FirstOrDefault(a => a.Ma == cbb_idguibc.Text).Id : null;
            thao.TrangThai = rbt_ttnvon.Checked ? 1 : 0;
            if (_QLCuaHangService.CheckMaNhanVien(tbx_manhanvien.Text))
            {
                MessageBox.Show("Mã đã tồn tại", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show(_QLCuaHangService.AddNhanVien(thao));
                LoadNhanVien(_QLCuaHangService.GetNhanVien());
                LoadCombobox();
            }
        }

        private void btn_suanv_Click(object sender, EventArgs e)
        {
            NhanVienView thao = new NhanVienView();
            thao.Id = IDNhanVien;
            thao.Ma = tbx_manhanvien.Text;
            thao.Ten = tbx_tennv.Text;
            thao.TenDem = tbx_tendemnv.Text;
            thao.Ho = tbx_honv.Text;
            thao.GioiTinh = tbx_gioitinh.Text;
            thao.NgaySinh = Convert.ToDateTime(dtp_ngaysinhnv.Value.ToString("MM/dd/yyyy"));
            thao.DiaChi = tbx_diachinv.Text;
            thao.Sdt = tbx_sdtnv.Text;
            thao.MatKhau = tbx_matkhaunv.Text;
            thao.IdCh = cbb_idcuahang.Text != null ? _QLCuaHangService.GetCuaHang().FirstOrDefault(a => a.Ten == cbb_idcuahang.Text).Id : null;
            thao.IdCv = cbb_idchucvu.Text != null ? _QLCuaHangService.GetChucVu().FirstOrDefault(a => a.Ten == cbb_idchucvu.Text).Id : null;
            //      thao.IdGuiBc = cbb_idguibc.Text != null ? _QLCuaHangService.GetNhanVien().FirstOrDefault(a => a.Ma == cbb_idguibc.Text).Id : null;
            thao.TrangThai = rbt_ttnvon.Checked ? 1 : 0;
            MessageBox.Show(_QLCuaHangService.UpdateNhanVien(thao));
            LoadNhanVien(_QLCuaHangService.GetNhanVien());
            LoadCombobox();
        }

        private void btn_xoanv_Click(object sender, EventArgs e)
        {
            NhanVienView thao = new NhanVienView();
            thao.Id = IDNhanVien;
            MessageBox.Show(_QLCuaHangService.DeleteNhanVien(thao));
            LoadNhanVien(_QLCuaHangService.GetNhanVien());
            LoadCombobox();
        }

        private void dtg_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDNhanVien = Guid.Parse(dtg_nhanvien.CurrentRow.Cells[1].Value.ToString());
            tbx_manhanvien.Text = dtg_nhanvien.CurrentRow.Cells[2].Value.ToString();
            tbx_tennv.Text = dtg_nhanvien.CurrentRow.Cells[3].Value.ToString();
            tbx_tendemnv.Text = dtg_nhanvien.CurrentRow.Cells[4].Value.ToString();
            tbx_honv.Text = dtg_nhanvien.CurrentRow.Cells[5].Value.ToString();
            tbx_gioitinh.Text = dtg_nhanvien.CurrentRow.Cells[6].Value.ToString();
            dtp_ngaysinhnv.Value = Convert.ToDateTime(dtg_nhanvien.CurrentRow.Cells[7].Value.ToString());
            tbx_diachinv.Text = dtg_nhanvien.CurrentRow.Cells[8].Value.ToString();
            tbx_sdtnv.Text = dtg_nhanvien.CurrentRow.Cells[9].Value.ToString();
            tbx_matkhaunv.Text = dtg_nhanvien.CurrentRow.Cells[10].Value.ToString();
            Guid getidcuahangs = Guid.Parse(dtg_nhanvien.CurrentRow.Cells[11].Value.ToString());
            cbb_idcuahang.Text = _QLCuaHangService.GetCuaHang().FirstOrDefault(a => a.Id == getidcuahangs).Ten;
            Guid getchucvus = Guid.Parse(dtg_nhanvien.CurrentRow.Cells[13].Value.ToString());
            cbb_idchucvu.Text = _QLCuaHangService.GetChucVu().FirstOrDefault(a => a.Id == getchucvus).Ten;
            int trangthais = Convert.ToInt32(dtg_nhanvien.CurrentRow.Cells[17].Value.ToString());
            if (trangthais == 1)
                rbt_ttnvon.Checked = true;
            else if (trangthais == 0)
                rbt_ttnvoff.Checked = true;
            else
            {
                rbt_ttnvon.Checked = false;
                rbt_ttnvoff.Checked = false;
            }

        }



        //DialogResult dlr = MessageBox.Show("Warrning !!!!!!!!", "Hãy suy nghĩ kĩ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        //if (dlr == DialogResult.Yes)
        //{
        //    //if (ich.CheckMa(tbx_mach.Text))
        //    //{
        //    //    MessageBox.Show("Mã đếch được trùng");
        //    //}


    }
}
