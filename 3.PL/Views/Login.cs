using _2.BUS.IService;
using _2.BUS.Service;

namespace _3.PL.Views
{
    public partial class Login : Form
    {
        private IQLCuaHangService iqlnvsv;

        public Login()
        {
            InitializeComponent();
            iqlnvsv = new QLCuaHangService();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult drl = MessageBox.Show("Warnning !!!", "Bạn có muốn thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (drl == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (iqlnvsv.CheckLogin(tbx_username.Text, tbx_password.Text))
            {
                MessageBox.Show("Login OK", $"Xin chào : {tbx_username.Text}", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                VNINDEX vid = new VNINDEX();
                vid.ShowDialog();
            }
            else
                MessageBox.Show("Username or Password not true", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
