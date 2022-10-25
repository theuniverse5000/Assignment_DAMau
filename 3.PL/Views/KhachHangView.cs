
//using _1.DAL.DomainClass;
using _2.BUS.IService;
using _2.BUS.Service;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class FormKhachHang : Form
    {
        IKhachHangService _khachHangService;
        Guid IDKhachHang;
        public FormKhachHang()
        {
            InitializeComponent();
            _khachHangService = new KhachHangService();
        }
        public void LoadKhachHang(List<KhachHangView> listkh)
        {
            //int stt = 0;
            //dtg_showkhachhang.Rows.Clear();
            //dtg_showkhachhang.ColumnCount = 12;
            //dtg_showkhachhang.Columns[0].Name = "STT";
            //dtg_showkhachhang.Columns[1].Name = "ID";
            //dtg_showkhachhang.Columns[1].Visible = false;
            //dtg_showkhachhang.Columns[2].Name = "Mã";
            //dtg_showkhachhang.Columns[3].Name = "Tên";
            //dtg_showkhachhang.Columns[4].Name = "Tên đệm";
            //dtg_showkhachhang.Columns[5].Name = "Họ";
            //dtg_showkhachhang.Columns[6].Name = "Ngày sinh";
            //dtg_showkhachhang.Columns[7].Name = "SĐT";
            //dtg_showkhachhang.Columns[8].Name = "Địa chỉ";
            //dtg_showkhachhang.Columns[9].Name = "Thành phố";
            //dtg_showkhachhang.Columns[10].Name = "Quốc gia";
            //dtg_showkhachhang.Columns[11].Name = "Mật khẩu";
            //foreach (var s in listkh)
            //{
            //    stt++;
            //    dtg_showkhachhang.Rows.Add(stt, s.KhachHang.Id, s.KhachHang.Ma, s.KhachHang.Ten, s.KhachHang.TenDem, s.KhachHang.Ho, s.KhachHang.NgaySinh,
            //        s.KhachHang.Sdt, s.KhachHang.DiaChi, s.KhachHang.ThanhPho, s.KhachHang.QuocGia, s.KhachHang.MatKhau);
            //}
            int stt = 0;
            dtg_showkhachhang.Rows.Clear();
            dtg_showkhachhang.ColumnCount = 12;
            dtg_showkhachhang.Columns[0].Name = "STT";
            dtg_showkhachhang.Columns[1].Name = "ID";
            dtg_showkhachhang.Columns[1].Visible = false;
            dtg_showkhachhang.Columns[2].Name = "Mã";
            dtg_showkhachhang.Columns[3].Name = "Tên";
            dtg_showkhachhang.Columns[4].Name = "Tên đệm";
            dtg_showkhachhang.Columns[5].Name = "Họ";
            dtg_showkhachhang.Columns[6].Name = "Ngày sinh";
            dtg_showkhachhang.Columns[7].Name = "SĐT";
            dtg_showkhachhang.Columns[8].Name = "Địa chỉ";
            dtg_showkhachhang.Columns[9].Name = "Thành phố";
            dtg_showkhachhang.Columns[10].Name = "Quốc gia";
            dtg_showkhachhang.Columns[11].Name = "Mật khẩu";
            foreach (var s in listkh)
            {
                stt++;
                dtg_showkhachhang.Rows.Add(stt, s.Id, s.Ma, s.Ten, s.TenDem, s.Ho, s.NgaySinh,
                    s.Sdt, s.DiaChi, s.ThanhPho, s.QuocGia, s.MatKhau);
            }
        }
        private void btn_themkh_Click(object sender, EventArgs e)
        {
            //var thao = new BanHangView();
            //thao.KhachHang = new _1.DAL.DomainClass.KhachHang();
            //thao.KhachHang.Ma = tbx_makh.Text;
            //thao.KhachHang.Ten = tbx_tenkh.Text;
            //thao.KhachHang.TenDem = tbx_tendemkh.Text;
            //thao.KhachHang.Ho = tbx_hokh.Text;
            //thao.KhachHang.NgaySinh = Convert.ToDateTime(dtp_ngaysinhkh.Value.ToString());
            //thao.KhachHang.Sdt = tbx_sdtkh.Text;
            //thao.KhachHang.DiaChi = tbx_diachikh.Text;
            //thao.KhachHang.ThanhPho = tbx_thanhphokh.Text;
            //thao.KhachHang.QuocGia = tbx_quocgiakh.Text;
            //thao.KhachHang.MatKhau = tbx_matkhaukh.Text;
            KhachHangView thaoview = new KhachHangView()
            {
                Ma = tbx_makh.Text,
                Ten = tbx_tenkh.Text,
                TenDem = tbx_tendemkh.Text,
                Ho = tbx_hokh.Text,
                NgaySinh = Convert.ToDateTime(dtp_ngaysinhkh.Value.ToString()),
                Sdt = tbx_sdtkh.Text,
                DiaChi = tbx_diachikh.Text,
                ThanhPho = tbx_thanhphokh.Text,
                QuocGia = tbx_quocgiakh.Text,
                MatKhau = tbx_matkhaukh.Text
            };
            if (_khachHangService.CheckMaKhachHang(tbx_makh.Text))
            {
                MessageBox.Show("Mã đã tồn tại", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show(_khachHangService.Addkh(thaoview));
                LoadKhachHang(_khachHangService.GetKhachHang());
            }

        }
        private void btn_suakh_Click(object sender, EventArgs e)
        {
            KhachHangView thaoview = new KhachHangView()
            {
                Id = IDKhachHang,
                Ma = tbx_makh.Text,
                Ten = tbx_tenkh.Text,
                TenDem = tbx_tendemkh.Text,
                Ho = tbx_hokh.Text,
                NgaySinh = Convert.ToDateTime(dtp_ngaysinhkh.Value.ToString()),
                Sdt = tbx_sdtkh.Text,
                DiaChi = tbx_diachikh.Text,
                ThanhPho = tbx_thanhphokh.Text,
                QuocGia = tbx_quocgiakh.Text,
                MatKhau = tbx_matkhaukh.Text
            };
            //thao.KhachHang.Id;
            //thao.KhachHang.Ma = tbx_makh.Text;
            //thao.KhachHang.Ten = tbx_tenkh.Text;
            //thao.KhachHang.TenDem = tbx_tendemkh.Text;
            //thao.KhachHang.Ho = tbx_hokh.Text;
            //thao.KhachHang.NgaySinh = Convert.ToDateTime(dtp_ngaysinhkh.Value.ToString());
            //thao.KhachHang.Sdt = tbx_sdtkh.Text;
            //thao.KhachHang.DiaChi = tbx_diachikh.Text;
            //thao.KhachHang.ThanhPho = tbx_thanhphokh.Text;
            //thao.KhachHang.QuocGia = tbx_quocgiakh.Text;
            //thao.KhachHang.MatKhau = tbx_matkhaukh.Text;
            MessageBox.Show(_khachHangService.Updatekh(thaoview));
            LoadKhachHang(_khachHangService.GetKhachHang());
        }

        private void btn_xoakh_Click(object sender, EventArgs e)
        {
            //KhachHangView thaoview = new KhachHangView()
            //{
            //    Id = IDKhachHang
            //};

           MessageBox.Show( _khachHangService.Deletekh(IDKhachHang));
            LoadKhachHang(_khachHangService.GetKhachHang());
        }

        private void KhachHangView_Load(object sender, EventArgs e)
        {
            LoadKhachHang(_khachHangService.GetKhachHang());
        }

        private void dtg_showkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDKhachHang = Guid.Parse(dtg_showkhachhang.CurrentRow.Cells[1].Value.ToString());
            tbx_makh.Text = dtg_showkhachhang.CurrentRow.Cells[2].Value.ToString();
            tbx_tenkh.Text = dtg_showkhachhang.CurrentRow.Cells[3].Value.ToString();
            tbx_tendemkh.Text = dtg_showkhachhang.CurrentRow.Cells[4].Value.ToString();
            tbx_hokh.Text = dtg_showkhachhang.CurrentRow.Cells[5].Value.ToString();
            dtp_ngaysinhkh.Value = Convert.ToDateTime(dtg_showkhachhang.CurrentRow.Cells[6].Value.ToString());
            tbx_sdtkh.Text = dtg_showkhachhang.CurrentRow.Cells[7].Value.ToString();
            tbx_diachikh.Text = dtg_showkhachhang.CurrentRow.Cells[8].Value.ToString();
            tbx_thanhphokh.Text = dtg_showkhachhang.CurrentRow.Cells[9].Value.ToString();
            tbx_quocgiakh.Text = dtg_showkhachhang.CurrentRow.Cells[10].Value.ToString();
            tbx_matkhaukh.Text = dtg_showkhachhang.CurrentRow.Cells[11].Value.ToString();

        }
    }
}
