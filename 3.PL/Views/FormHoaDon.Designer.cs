namespace _3.PL.Views
{
    partial class FormHoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtg_hoadon = new System.Windows.Forms.DataGridView();
            this.dtp_ngayship = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngaynhan = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_xoahoadon = new System.Windows.Forms.Button();
            this.btn_suahoadon = new System.Windows.Forms.Button();
            this.btn_themhoadon = new System.Windows.Forms.Button();
            this.dtp_ngaytao = new System.Windows.Forms.DateTimePicker();
            this.dtp_ngaythanhtoan = new System.Windows.Forms.DateTimePicker();
            this.rbt_1 = new System.Windows.Forms.RadioButton();
            this.rbt_0 = new System.Windows.Forms.RadioButton();
            this.tbx_sdtnguoinhan = new System.Windows.Forms.TextBox();
            this.tbx_diachinguoinhan = new System.Windows.Forms.TextBox();
            this.tbx_tennguoinhan = new System.Windows.Forms.TextBox();
            this.tbx_mahd = new System.Windows.Forms.TextBox();
            this.cbb_idkhachhang = new System.Windows.Forms.ComboBox();
            this.cbb_idnhanvien = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_hoadon);
            this.groupBox1.Controls.Add(this.dtp_ngayship);
            this.groupBox1.Controls.Add(this.dtp_ngaynhan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btn_xoahoadon);
            this.groupBox1.Controls.Add(this.btn_suahoadon);
            this.groupBox1.Controls.Add(this.btn_themhoadon);
            this.groupBox1.Controls.Add(this.dtp_ngaytao);
            this.groupBox1.Controls.Add(this.dtp_ngaythanhtoan);
            this.groupBox1.Controls.Add(this.rbt_1);
            this.groupBox1.Controls.Add(this.rbt_0);
            this.groupBox1.Controls.Add(this.tbx_sdtnguoinhan);
            this.groupBox1.Controls.Add(this.tbx_diachinguoinhan);
            this.groupBox1.Controls.Add(this.tbx_tennguoinhan);
            this.groupBox1.Controls.Add(this.tbx_mahd);
            this.groupBox1.Controls.Add(this.cbb_idkhachhang);
            this.groupBox1.Controls.Add(this.cbb_idnhanvien);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1227, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa Đơn";
            // 
            // dtg_hoadon
            // 
            this.dtg_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_hoadon.Location = new System.Drawing.Point(371, 22);
            this.dtg_hoadon.Name = "dtg_hoadon";
            this.dtg_hoadon.RowTemplate.Height = 25;
            this.dtg_hoadon.Size = new System.Drawing.Size(884, 457);
            this.dtg_hoadon.TabIndex = 55;
            this.dtg_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_hoadon_CellClick);
            // 
            // dtp_ngayship
            // 
            this.dtp_ngayship.Location = new System.Drawing.Point(108, 185);
            this.dtp_ngayship.Name = "dtp_ngayship";
            this.dtp_ngayship.Size = new System.Drawing.Size(200, 23);
            this.dtp_ngayship.TabIndex = 54;
            // 
            // dtp_ngaynhan
            // 
            this.dtp_ngaynhan.Location = new System.Drawing.Point(108, 222);
            this.dtp_ngaynhan.Name = "dtp_ngaynhan";
            this.dtp_ngaynhan.Size = new System.Drawing.Size(200, 23);
            this.dtp_ngaynhan.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 52;
            this.label10.Text = "Ngày nhận";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 51;
            this.label11.Text = "Ngày ship";
            // 
            // btn_xoahoadon
            // 
            this.btn_xoahoadon.BackColor = System.Drawing.Color.Red;
            this.btn_xoahoadon.Location = new System.Drawing.Point(299, 350);
            this.btn_xoahoadon.Name = "btn_xoahoadon";
            this.btn_xoahoadon.Size = new System.Drawing.Size(66, 23);
            this.btn_xoahoadon.TabIndex = 50;
            this.btn_xoahoadon.Text = "Xóa";
            this.btn_xoahoadon.UseVisualStyleBackColor = false;
            this.btn_xoahoadon.Click += new System.EventHandler(this.btn_xoahoadon_Click);
            // 
            // btn_suahoadon
            // 
            this.btn_suahoadon.BackColor = System.Drawing.Color.Fuchsia;
            this.btn_suahoadon.Location = new System.Drawing.Point(299, 305);
            this.btn_suahoadon.Name = "btn_suahoadon";
            this.btn_suahoadon.Size = new System.Drawing.Size(66, 23);
            this.btn_suahoadon.TabIndex = 49;
            this.btn_suahoadon.Text = "Sửa";
            this.btn_suahoadon.UseVisualStyleBackColor = false;
            this.btn_suahoadon.Click += new System.EventHandler(this.btn_suahoadon_Click);
            // 
            // btn_themhoadon
            // 
            this.btn_themhoadon.BackColor = System.Drawing.Color.Lime;
            this.btn_themhoadon.Location = new System.Drawing.Point(299, 255);
            this.btn_themhoadon.Name = "btn_themhoadon";
            this.btn_themhoadon.Size = new System.Drawing.Size(66, 23);
            this.btn_themhoadon.TabIndex = 48;
            this.btn_themhoadon.Text = "Thêm";
            this.btn_themhoadon.UseVisualStyleBackColor = false;
            this.btn_themhoadon.Click += new System.EventHandler(this.btn_themhoadon_Click);
            // 
            // dtp_ngaytao
            // 
            this.dtp_ngaytao.Location = new System.Drawing.Point(108, 131);
            this.dtp_ngaytao.Name = "dtp_ngaytao";
            this.dtp_ngaytao.Size = new System.Drawing.Size(200, 23);
            this.dtp_ngaytao.TabIndex = 47;
            // 
            // dtp_ngaythanhtoan
            // 
            this.dtp_ngaythanhtoan.Location = new System.Drawing.Point(121, 156);
            this.dtp_ngaythanhtoan.Name = "dtp_ngaythanhtoan";
            this.dtp_ngaythanhtoan.Size = new System.Drawing.Size(200, 23);
            this.dtp_ngaythanhtoan.TabIndex = 46;
            // 
            // rbt_1
            // 
            this.rbt_1.AutoSize = true;
            this.rbt_1.Location = new System.Drawing.Point(78, 350);
            this.rbt_1.Name = "rbt_1";
            this.rbt_1.Size = new System.Drawing.Size(100, 19);
            this.rbt_1.TabIndex = 45;
            this.rbt_1.TabStop = true;
            this.rbt_1.Text = "Đã thanh toán";
            this.rbt_1.UseVisualStyleBackColor = true;
            // 
            // rbt_0
            // 
            this.rbt_0.AutoSize = true;
            this.rbt_0.Location = new System.Drawing.Point(179, 352);
            this.rbt_0.Name = "rbt_0";
            this.rbt_0.Size = new System.Drawing.Size(114, 19);
            this.rbt_0.TabIndex = 44;
            this.rbt_0.TabStop = true;
            this.rbt_0.Text = "Chưa thanh toán";
            this.rbt_0.UseVisualStyleBackColor = true;
            // 
            // tbx_sdtnguoinhan
            // 
            this.tbx_sdtnguoinhan.Location = new System.Drawing.Point(108, 321);
            this.tbx_sdtnguoinhan.Name = "tbx_sdtnguoinhan";
            this.tbx_sdtnguoinhan.Size = new System.Drawing.Size(100, 23);
            this.tbx_sdtnguoinhan.TabIndex = 32;
            // 
            // tbx_diachinguoinhan
            // 
            this.tbx_diachinguoinhan.Location = new System.Drawing.Point(107, 292);
            this.tbx_diachinguoinhan.Name = "tbx_diachinguoinhan";
            this.tbx_diachinguoinhan.Size = new System.Drawing.Size(100, 23);
            this.tbx_diachinguoinhan.TabIndex = 34;
            // 
            // tbx_tennguoinhan
            // 
            this.tbx_tennguoinhan.Location = new System.Drawing.Point(107, 255);
            this.tbx_tennguoinhan.Name = "tbx_tennguoinhan";
            this.tbx_tennguoinhan.Size = new System.Drawing.Size(100, 23);
            this.tbx_tennguoinhan.TabIndex = 36;
            // 
            // tbx_mahd
            // 
            this.tbx_mahd.Location = new System.Drawing.Point(108, 102);
            this.tbx_mahd.Name = "tbx_mahd";
            this.tbx_mahd.Size = new System.Drawing.Size(100, 23);
            this.tbx_mahd.TabIndex = 39;
            // 
            // cbb_idkhachhang
            // 
            this.cbb_idkhachhang.FormattingEnabled = true;
            this.cbb_idkhachhang.Location = new System.Drawing.Point(108, 38);
            this.cbb_idkhachhang.Name = "cbb_idkhachhang";
            this.cbb_idkhachhang.Size = new System.Drawing.Size(121, 23);
            this.cbb_idkhachhang.TabIndex = 43;
            // 
            // cbb_idnhanvien
            // 
            this.cbb_idnhanvien.FormattingEnabled = true;
            this.cbb_idnhanvien.Location = new System.Drawing.Point(108, 70);
            this.cbb_idnhanvien.Name = "cbb_idnhanvien";
            this.cbb_idnhanvien.Size = new System.Drawing.Size(121, 23);
            this.cbb_idnhanvien.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 41;
            this.label9.Text = "Tên người nhận";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 40;
            this.label8.Text = "Ngày thanh toán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 37;
            this.label6.Text = "Ngày tạo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Mã";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tình trạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "SĐT khách hàng";
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 509);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormHoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_hoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtp_ngayship;
        private DateTimePicker dtp_ngaynhan;
        private Label label10;
        private Label label11;
        private Button btn_xoahoadon;
        private Button btn_suahoadon;
        private Button btn_themhoadon;
        private DateTimePicker dtp_ngaytao;
        private DateTimePicker dtp_ngaythanhtoan;
        private RadioButton rbt_1;
        private RadioButton rbt_0;
        private TextBox tbx_sdtnguoinhan;
        private TextBox tbx_diachinguoinhan;
        private TextBox tbx_tennguoinhan;
        private TextBox tbx_mahd;
        private ComboBox cbb_idkhachhang;
        private ComboBox cbb_idnhanvien;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dtg_hoadon;
    }
}