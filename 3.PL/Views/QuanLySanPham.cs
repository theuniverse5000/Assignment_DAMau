using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class QuanLySanPham : Form
    {
        IQLSPService _qLSPService;
        Guid IDsp { get; set; }
        Guid IDdsp { get; set; }
        Guid IDnsx { get; set; }
        Guid IDmausac { get; set; }
        Guid IDCTsp { get; set; }


        public QuanLySanPham()
        {
            InitializeComponent();
            _qLSPService = new QLSPService();
        }
        // Viết các hàm để load dữ liệu cho từng bảng
        public void LoadSP(List<SanPhamView> list)
        {
            int stt = 0;
            dtg_sanpham.Rows.Clear();
            dtg_sanpham.ColumnCount = 4;
            dtg_sanpham.Columns[0].Name = "ID";
            dtg_sanpham.Columns[0].Visible = false;
            dtg_sanpham.Columns[1].Name = "STT";
            dtg_sanpham.Columns[2].Name = "Mã sản phẩm";
            dtg_sanpham.Columns[3].Name = "Tên sản phẩm";
            foreach (var t in list)
            {
                stt++;
                dtg_sanpham.Rows.Add(t.Id, stt, t.Ma, t.Ten);
            }
        }
        public void LoadDongSP(List<DongSanPhamView> listdspv)
        {
            dtg_dongsp.Rows.Clear();
            int stt = 0;
            dtg_dongsp.ColumnCount = 4;
            dtg_dongsp.Columns[0].Name = "ID";
            dtg_dongsp.Columns[0].Visible = false;
            dtg_dongsp.Columns[1].Name = "STT";
            dtg_dongsp.Columns[2].Name = "Mã dòng sản phẩm";
            dtg_dongsp.Columns[3].Name = "Tên dòng sản phẩm";
            foreach (var dsp in listdspv)
            {
                stt++;
                dtg_dongsp.Rows.Add(dsp.Id, stt, dsp.Ma, dsp.Ten);
            }
        }
        public void LoadNSX(List<NhaSanXuatView> listnsx)
        {
            int stt = 0;
            dtg_nsx.Rows.Clear();
            dtg_nsx.ColumnCount = 4;
            dtg_nsx.Columns[0].Name = "ID";
            dtg_nsx.Columns[0].Visible = false;
            dtg_nsx.Columns[1].Name = "STT";
            dtg_nsx.Columns[2].Name = "Mã nhà sản xuất";
            dtg_nsx.Columns[3].Name = "Tên nhà sản xuất ";
            foreach (var n in listnsx)
            {
                stt++;
                dtg_nsx.Rows.Add(n.Id, stt, n.Ma, n.Ten);
            }
        }
        public void LoadMauSac(List<MauSacView> listms)
        {
            int stt = 0;
            dtg_mausac.Rows.Clear();
            dtg_mausac.ColumnCount = 4;
            dtg_mausac.Columns[0].Name = "STT";
            dtg_mausac.Columns[1].Name = "ID";
            dtg_mausac.Columns[1].Visible = false;
            dtg_mausac.Columns[2].Name = "Mã ";
            dtg_mausac.Columns[3].Name = "Màu sắc";
            foreach (var m in listms)
            {
                stt++;
                dtg_mausac.Rows.Add(stt, m.Id, m.Ma, m.Ten);
            }

        }
        public void LoadCTSanPham(List<ChiTietSanPhamView> listctsp)
        {
            int stt = 0;
            dtg_chitietsp.Rows.Clear();
            dtg_chitietsp.ColumnCount = 15;
            dtg_chitietsp.Columns[0].Name = "STT";
            dtg_chitietsp.Columns[1].Name = "ID";
            dtg_chitietsp.Columns[1].Visible = false;
            dtg_chitietsp.Columns[2].Name = "ID Sản phẩm";
            dtg_chitietsp.Columns[2].Visible = false;
            dtg_chitietsp.Columns[3].Name = "Sản phẩm";
            dtg_chitietsp.Columns[4].Name = "ID Nhà sản xuất";
            dtg_chitietsp.Columns[4].Visible = false;
            dtg_chitietsp.Columns[5].Name = "Nhà sản xuất";
            dtg_chitietsp.Columns[6].Name = "ID Màu sắc";
            dtg_chitietsp.Columns[6].Visible = false;
            dtg_chitietsp.Columns[7].Name = "Màu sắc";
            dtg_chitietsp.Columns[8].Name = "ID Dòng Sản Phẩm";
            dtg_chitietsp.Columns[8].Visible = false;
            dtg_chitietsp.Columns[9].Name = "Dòng sản phẩm";
            dtg_chitietsp.Columns[10].Name = "Năm bảo hành";
            dtg_chitietsp.Columns[11].Name = "Mô tả";
            dtg_chitietsp.Columns[12].Name = "Số lượng tồn";
            dtg_chitietsp.Columns[13].Name = "Giá nhập";
            dtg_chitietsp.Columns[14].Name = "Giá bán";

            foreach (var t in listctsp)
            {
                //string tensanpham = _qLSPService.GetSP().FirstOrDefault(a => a.Id == t.IdSp).Ten;
                //string tennsx = _qLSPService.GetNSX().FirstOrDefault(a => a.Id == t.IdNsx).Ten;
                //string tenmausac = _qLSPService.GetMauSac().FirstOrDefault(a => a.Id == t.IdMauSac).Ten;
                //string tendongsp = _qLSPService.GetDSP().FirstOrDefault(a => a.Id == t.IdDongSp).Ten;
                stt++;
                dtg_chitietsp.Rows.Add(stt, t.Id, t.IdSp, t.TenSanPham, t.IdNsx, t.TenNhaSanXuat, t.IdMauSac, t.TenMauSac,
                    t.IdDongSp, t.TenDongSanPham, t.NamBh, t.MoTa, t.SoLuongTon, t.GiaNhap, t.GiaBan);
            }

            LoadCombobox();
        }
        public void LoadCombobox()
        {
            //Dùng LINQ lấy các thông tin load vào combobox để CRUD cho tiện
            var gettensp = from a in _qLSPService.GetSP()
                           select a.Ten;
            foreach (var s in gettensp)
            {
                cbb_idsp.Items.Add(s);
            }

            var gettennsx = from a in _qLSPService.GetNSX()
                            select a.Ten;
            foreach (var s in gettennsx)
            {
                cbb_idnsx.Items.Add(s);

            }
            var gettenms = from a in _qLSPService.GetMauSac()
                           select a.Ten;
            foreach (var s in gettenms)
            {
                cbb_idms.Items.Add(s);

            }
            var gettendsp = from a in _qLSPService.GetDSP()
                            select a.Ten;
            foreach (var s in gettendsp)
            {
                cbb_iddsp.Items.Add(s);

            }
        }
        // Load dữ liệu cho cả form QuanLySanPham - Gọi tất cả các method load của các bảng 
        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            LoadSP(_qLSPService.GetSP());
            LoadDongSP(_qLSPService.GetDSP());
            LoadNSX(_qLSPService.GetNSX());
            LoadMauSac(_qLSPService.GetMauSac());
            LoadCTSanPham(_qLSPService.GetCTSP());
        }

        // CRUD sản phẩm
        private void btn_themsp_Click(object sender, EventArgs e)
        {
            SanPhamView thaoview = new SanPhamView();

            thaoview.Ma = tbx_masp.Text;
            thaoview.Ten = tbx_tensp.Text;
            if (_qLSPService.CheckMaSP(tbx_masp.Text))
            {
                MessageBox.Show("Mã đã tồn tại");
            }
            else
            {
                MessageBox.Show(_qLSPService.AddSP(thaoview));
                LoadSP(_qLSPService.GetSP());
            }
        }

        private void btn_suasp_Click(object sender, EventArgs e)
        {
            SanPhamView thaoview = new SanPhamView();
            thaoview.Id = IDsp;
            thaoview.Ma = tbx_masp.Text;
            thaoview.Ten = tbx_tensp.Text;
            MessageBox.Show(_qLSPService.UpdateSP(thaoview));
            LoadSP(_qLSPService.GetSP());


        }

        private void dtg_sanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDsp = Guid.Parse(dtg_sanpham.CurrentRow.Cells[0].Value.ToString());
            tbx_tensp.Text = dtg_sanpham.CurrentRow.Cells[3].Value.ToString();
            tbx_masp.Text = dtg_sanpham.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_xoasp_Click(object sender, EventArgs e)
        {
            SanPhamView thaoview = new SanPhamView();
            thaoview.Id = IDsp;

            MessageBox.Show(_qLSPService.DeleteSP(thaoview));
            LoadSP(_qLSPService.GetSP());

        }
        // CRUD dòng sản phẩm

        private void btn_themdsp_Click(object sender, EventArgs e)
        {
            DongSanPhamView thao = new DongSanPhamView();
            thao.Ma = tbx_madsp.Text;
            thao.Ten = tbx_tendsp.Text;
            if (_qLSPService.CheckDSP(tbx_madsp.Text))
            {
                MessageBox.Show("Mã đã tồn tại");
            }
            else
            {
                MessageBox.Show(_qLSPService.AddDSP(thao));
                LoadDongSP(_qLSPService.GetDSP());
            }

        }

        private void btn_suadsp_Click(object sender, EventArgs e)
        {
            DongSanPhamView thao = new DongSanPhamView();
            thao.Ma = tbx_madsp.Text;
            thao.Ten = tbx_tendsp.Text;
            thao.Id = IDdsp;
            MessageBox.Show(_qLSPService.UpdateDSP(thao));
            LoadDongSP(_qLSPService.GetDSP());

        }

        private void btn_xoadsp_Click(object sender, EventArgs e)
        {
            DongSanPhamView thao = new DongSanPhamView();
            thao.Ma = tbx_madsp.Text;
            thao.Ten = tbx_tendsp.Text;
            thao.Id = IDdsp;
            MessageBox.Show(_qLSPService.DeleteDSP(thao));
            LoadDongSP(_qLSPService.GetDSP());
        }

        private void dtg_dongsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDdsp = Guid.Parse(dtg_dongsp.CurrentRow.Cells[0].Value.ToString());
            tbx_tendsp.Text = dtg_dongsp.CurrentRow.Cells[3].Value.ToString();
            tbx_madsp.Text = dtg_dongsp.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_themnsx_Click(object sender, EventArgs e)
        {
            NhaSanXuatView thaoview = new NhaSanXuatView()
            {
                Ma = tbx_mansx.Text,
                Ten = tbx_tennsx.Text

            };
            if (_qLSPService.CheckNSX(tbx_mansx.Text))
            {
                MessageBox.Show("Mã đã tồn tại");
            }
            else
            {
                MessageBox.Show(_qLSPService.AddNSX(thaoview));
                LoadNSX(_qLSPService.GetNSX());
            }

        }

        private void btn_suansx_Click(object sender, EventArgs e)
        {
            NhaSanXuatView thaoview = new NhaSanXuatView()
            {
                Id = IDnsx,
                Ma = tbx_mansx.Text,
                Ten = tbx_tennsx.Text

            };
            MessageBox.Show(_qLSPService.UpdateNSX(thaoview));
            LoadNSX(_qLSPService.GetNSX());

        }

        private void btn_xoansx_Click(object sender, EventArgs e)
        {
            NhaSanXuatView thaoview = new NhaSanXuatView()
            {
                Id = IDnsx

            };
            MessageBox.Show(_qLSPService.DeleteNSX(thaoview));
            LoadNSX(_qLSPService.GetNSX());
        }

        private void dtg_nsx_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDnsx = Guid.Parse(dtg_nsx.CurrentRow.Cells[0].Value.ToString());
            tbx_tennsx.Text = dtg_nsx.CurrentRow.Cells[3].Value.ToString();
            tbx_mansx.Text = dtg_nsx.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_themms_Click(object sender, EventArgs e)
        {
            MauSacView violet = new MauSacView()
            {
                Ma = tbx_mams.Text,
                Ten = tbx_tenms.Text
            };

            if (_qLSPService.CheckMS(tbx_mams.Text))
            {
                MessageBox.Show("Mã đã tồn tại");
            }
            else
            {
                MessageBox.Show(_qLSPService.AddMS(violet));
                LoadMauSac(_qLSPService.GetMauSac());
            }
        }

        private void btn_suams_Click(object sender, EventArgs e)
        {
            MauSacView violet = new MauSacView()
            {
                Id = IDmausac,
                Ma = tbx_mams.Text,
                Ten = tbx_tenms.Text
            };
            MessageBox.Show(_qLSPService.UpdateMS(violet));
            LoadMauSac(_qLSPService.GetMauSac());


        }

        private void btn_xoams_Click(object sender, EventArgs e)
        {
            MauSacView violet = new MauSacView()
            {
                Id = IDmausac
            };

            MessageBox.Show(_qLSPService.DeleteMS(violet));
            LoadMauSac(_qLSPService.GetMauSac());
        }

        private void dtg_mausac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDmausac = Guid.Parse(dtg_mausac.CurrentRow.Cells[1].Value.ToString());
            tbx_mams.Text = dtg_mausac.CurrentRow.Cells[2].Value.ToString();
            tbx_tenms.Text = dtg_mausac.CurrentRow.Cells[3].Value.ToString();

        }

        private void btn_themctsp_Click(object sender, EventArgs e)
        {
            ChiTietSanPhamView thao = new ChiTietSanPhamView();
            thao.IdMauSac = cbb_idms.Text != null ? _qLSPService.GetMauSac().FirstOrDefault(a => a.Ten == cbb_idms.Text).Id : null;
            //   thao.IdMauSac = Guid.Parse(cbb_idms.Text);
            thao.IdSp = cbb_idsp.Text != null ? _qLSPService.GetSP().FirstOrDefault(a => a.Ten == cbb_idsp.Text).Id : null;
            //thao.IdNsx = Guid.Parse(cbb_idnsx.Text);
            thao.IdNsx = cbb_idnsx.Text != null ? _qLSPService.GetNSX().FirstOrDefault(a => a.Ten == cbb_idnsx.Text).Id : null;
            //thao.IdDongSp = Guid.Parse(cbb_iddsp.Text);
            thao.IdDongSp = cbb_iddsp.Text != null ? _qLSPService.GetDSP().FirstOrDefault(a => a.Ten == cbb_iddsp.Text).Id : null;
            thao.NamBh = Convert.ToInt32(tbx_nambaohanh.Text);
            thao.MoTa = tbx_mota.Text;
            thao.SoLuongTon = Convert.ToInt32(tbx_slton.Text);
            thao.GiaNhap = Convert.ToDecimal(tbx_gianhap.Text);
            thao.GiaBan = Convert.ToDecimal(tbx_giaban.Text);
            _qLSPService.AddCTSP(thao);
            LoadCTSanPham(_qLSPService.GetCTSP());
        }

        private void btn_suactsp_Click(object sender, EventArgs e)
        {
            ChiTietSanPhamView thao = new ChiTietSanPhamView();
            thao.Id = IDCTsp;
            thao.IdMauSac = cbb_idms.Text != null ? _qLSPService.GetMauSac().FirstOrDefault(a => a.Ten == cbb_idms.Text).Id : null;
            //   thao.IdMauSac = Guid.Parse(cbb_idms.Text);
            thao.IdSp = cbb_idsp.Text != null ? _qLSPService.GetSP().FirstOrDefault(a => a.Ten == cbb_idsp.Text).Id : null;
            //thao.IdNsx = Guid.Parse(cbb_idnsx.Text);
            thao.IdNsx = cbb_idnsx.Text != null ? _qLSPService.GetNSX().FirstOrDefault(a => a.Ten == cbb_idnsx.Text).Id : null;
            //thao.IdDongSp = Guid.Parse(cbb_iddsp.Text);
            thao.IdDongSp = cbb_iddsp.Text != null ? _qLSPService.GetDSP().FirstOrDefault(a => a.Ten == cbb_iddsp.Text).Id : null;
            thao.NamBh = Convert.ToInt32(tbx_nambaohanh.Text);
            thao.MoTa = tbx_mota.Text;
            thao.SoLuongTon = Convert.ToInt32(tbx_slton.Text);
            thao.GiaNhap = Convert.ToDecimal(tbx_gianhap.Text);
            thao.GiaBan = Convert.ToDecimal(tbx_giaban.Text);
            _qLSPService.UpdateCTSP(thao);
            LoadCTSanPham(_qLSPService.GetCTSP());
        }

        private void btn_xoactsp_Click(object sender, EventArgs e)
        {
            ChiTietSanPhamView thao = new ChiTietSanPhamView();
            thao.Id = IDCTsp;
            _qLSPService.DeleteCTSP(thao);
            LoadCTSanPham(_qLSPService.GetCTSP());
        }

        private void dtg_chitietsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDCTsp = Guid.Parse(dtg_chitietsp.CurrentRow.Cells[1].Value.ToString());
            Guid idsps = Guid.Parse(dtg_chitietsp.CurrentRow.Cells[2].Value.ToString());
            cbb_idsp.Text = _qLSPService.GetSP().FirstOrDefault(a => a.Id == idsps).Ten;
            Guid idnsxs = Guid.Parse(dtg_chitietsp.CurrentRow.Cells[4].Value.ToString());
            cbb_idnsx.Text = _qLSPService.GetNSX().FirstOrDefault(a => a.Id == idnsxs).Ten;
            Guid idmss = Guid.Parse(dtg_chitietsp.CurrentRow.Cells[6].Value.ToString());
            cbb_idms.Text = _qLSPService.GetMauSac().FirstOrDefault(a => a.Id == idmss).Ten;
            Guid iddsps = Guid.Parse(dtg_chitietsp.CurrentRow.Cells[8].Value.ToString());
            cbb_iddsp.Text = _qLSPService.GetDSP().FirstOrDefault(a => a.Id == iddsps).Ten;
            tbx_nambaohanh.Text = dtg_chitietsp.CurrentRow.Cells[10].Value.ToString();
            tbx_mota.Text = dtg_chitietsp.CurrentRow.Cells[11].Value.ToString();
            tbx_slton.Text = dtg_chitietsp.CurrentRow.Cells[12].Value.ToString();
            tbx_gianhap.Text = dtg_chitietsp.CurrentRow.Cells[13].Value.ToString();
            tbx_giaban.Text = dtg_chitietsp.CurrentRow.Cells[14].Value.ToString();
        }
    }
}
