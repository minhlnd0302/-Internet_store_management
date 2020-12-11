namespace QLInternetUI
{
    partial class frmAdmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lsvShow = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbSoTienThem = new System.Windows.Forms.TextBox();
            this.txbSDT = new System.Windows.Forms.MaskedTextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThemTien = new System.Windows.Forms.Button();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.txbTenTK = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lsvThongKe = new System.Windows.Forms.ListView();
            this.grbLichSu = new System.Windows.Forms.GroupBox();
            this.pnt1 = new System.Windows.Forms.Panel();
            this.tbtNgayLS = new System.Windows.Forms.RadioButton();
            this.rbtNamLS = new System.Windows.Forms.RadioButton();
            this.rbtThangLS = new System.Windows.Forms.RadioButton();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnLsGdHeThong = new System.Windows.Forms.Button();
            this.btnLichSuGDtk = new System.Windows.Forms.Button();
            this.txbTkTk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThayDoiGiaDV = new System.Windows.Forms.Button();
            this.txbmk = new System.Windows.Forms.TextBox();
            this.txbGiaMoi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.giamoi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbMKhienTai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.txbMKnhapLai = new System.Windows.Forms.TextBox();
            this.txbMKmoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerUpdateData = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grbLichSu.SuspendLayout();
            this.pnt1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(25, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 464);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lsvShow);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lsvShow
            // 
            this.lsvShow.GridLines = true;
            this.lsvShow.HideSelection = false;
            this.lsvShow.Location = new System.Drawing.Point(53, 259);
            this.lsvShow.Name = "lsvShow";
            this.lsvShow.Size = new System.Drawing.Size(586, 154);
            this.lsvShow.TabIndex = 5;
            this.lsvShow.UseCompatibleStateImageBehavior = false;
            this.lsvShow.View = System.Windows.Forms.View.Details;
            this.lsvShow.SelectedIndexChanged += new System.EventHandler(this.lsvShow_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbSoTienThem);
            this.groupBox2.Controls.Add(this.txbSDT);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnThemTien);
            this.groupBox2.Controls.Add(this.btnThucHien);
            this.groupBox2.Controls.Add(this.btnHuyBo);
            this.groupBox2.Controls.Add(this.btnChinhSua);
            this.groupBox2.Controls.Add(this.btnXoaTK);
            this.groupBox2.Controls.Add(this.btnThemTK);
            this.groupBox2.Controls.Add(this.txbEmail);
            this.groupBox2.Controls.Add(this.txbMatKhau);
            this.groupBox2.Controls.Add(this.txbTenTK);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(53, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 224);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tài khoản khách hàng";
            // 
            // txbSoTienThem
            // 
            this.txbSoTienThem.Enabled = false;
            this.txbSoTienThem.Location = new System.Drawing.Point(131, 183);
            this.txbSoTienThem.Name = "txbSoTienThem";
            this.txbSoTienThem.Size = new System.Drawing.Size(121, 20);
            this.txbSoTienThem.TabIndex = 4;
            // 
            // txbSDT
            // 
            this.txbSDT.Enabled = false;
            this.txbSDT.Location = new System.Drawing.Point(131, 107);
            this.txbSDT.Mask = "0000 000 000";
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.PromptChar = ' ';
            this.txbSDT.Size = new System.Drawing.Size(121, 20);
            this.txbSDT.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(448, 130);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThemTien
            // 
            this.btnThemTien.Location = new System.Drawing.Point(448, 75);
            this.btnThemTien.Name = "btnThemTien";
            this.btnThemTien.Size = new System.Drawing.Size(75, 23);
            this.btnThemTien.TabIndex = 2;
            this.btnThemTien.Text = "Thêm tiền";
            this.btnThemTien.UseVisualStyleBackColor = true;
            this.btnThemTien.Click += new System.EventHandler(this.btnThemTien_Click);
            // 
            // btnThucHien
            // 
            this.btnThucHien.Enabled = false;
            this.btnThucHien.Location = new System.Drawing.Point(335, 176);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(188, 32);
            this.btnThucHien.TabIndex = 2;
            this.btnThucHien.Text = "Thực hiện";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Enabled = false;
            this.btnHuyBo.Location = new System.Drawing.Point(335, 130);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(75, 23);
            this.btnHuyBo.TabIndex = 2;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.Location = new System.Drawing.Point(335, 77);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(75, 23);
            this.btnChinhSua.TabIndex = 2;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.Location = new System.Drawing.Point(448, 26);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTK.TabIndex = 2;
            this.btnXoaTK.Text = "Xóa TK";
            this.btnXoaTK.UseVisualStyleBackColor = true;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnThemTK
            // 
            this.btnThemTK.Location = new System.Drawing.Point(335, 26);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(75, 23);
            this.btnThemTK.TabIndex = 2;
            this.btnThemTK.Text = "Thêm TK";
            this.btnThemTK.UseVisualStyleBackColor = true;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Enabled = false;
            this.txbEmail.Location = new System.Drawing.Point(131, 144);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(121, 20);
            this.txbEmail.TabIndex = 1;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Enabled = false;
            this.txbMatKhau.Location = new System.Drawing.Point(131, 71);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.PasswordChar = '*';
            this.txbMatKhau.Size = new System.Drawing.Size(121, 20);
            this.txbMatKhau.TabIndex = 1;
            // 
            // txbTenTK
            // 
            this.txbTenTK.Enabled = false;
            this.txbTenTK.Location = new System.Drawing.Point(131, 32);
            this.txbTenTK.Name = "txbTenTK";
            this.txbTenTK.Size = new System.Drawing.Size(121, 20);
            this.txbTenTK.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số tiền thêm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Số điện thoại";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mật khẩu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Tên tài khoản";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(296, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(167, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Quản lý khách hàng";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lsvThongKe);
            this.tabPage2.Controls.Add(this.grbLichSu);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(692, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cài đặt & Thống kê & Lịch sử";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lsvThongKe
            // 
            this.lsvThongKe.GridLines = true;
            this.lsvThongKe.HideSelection = false;
            this.lsvThongKe.Location = new System.Drawing.Point(15, 230);
            this.lsvThongKe.Name = "lsvThongKe";
            this.lsvThongKe.Size = new System.Drawing.Size(662, 178);
            this.lsvThongKe.TabIndex = 3;
            this.lsvThongKe.UseCompatibleStateImageBehavior = false;
            this.lsvThongKe.View = System.Windows.Forms.View.Details;
            // 
            // grbLichSu
            // 
            this.grbLichSu.Controls.Add(this.pnt1);
            this.grbLichSu.Controls.Add(this.btnThongKe);
            this.grbLichSu.Controls.Add(this.btnLsGdHeThong);
            this.grbLichSu.Controls.Add(this.btnLichSuGDtk);
            this.grbLichSu.Controls.Add(this.txbTkTk);
            this.grbLichSu.Controls.Add(this.label4);
            this.grbLichSu.Location = new System.Drawing.Point(473, 19);
            this.grbLichSu.Name = "grbLichSu";
            this.grbLichSu.Size = new System.Drawing.Size(204, 184);
            this.grbLichSu.TabIndex = 2;
            this.grbLichSu.TabStop = false;
            this.grbLichSu.Text = "Lịch sử";
            // 
            // pnt1
            // 
            this.pnt1.Controls.Add(this.tbtNgayLS);
            this.pnt1.Controls.Add(this.rbtNamLS);
            this.pnt1.Controls.Add(this.rbtThangLS);
            this.pnt1.Location = new System.Drawing.Point(19, 37);
            this.pnt1.Name = "pnt1";
            this.pnt1.Size = new System.Drawing.Size(60, 97);
            this.pnt1.TabIndex = 5;
            // 
            // tbtNgayLS
            // 
            this.tbtNgayLS.AutoSize = true;
            this.tbtNgayLS.Checked = true;
            this.tbtNgayLS.Location = new System.Drawing.Point(3, 3);
            this.tbtNgayLS.Name = "tbtNgayLS";
            this.tbtNgayLS.Size = new System.Drawing.Size(50, 17);
            this.tbtNgayLS.TabIndex = 4;
            this.tbtNgayLS.TabStop = true;
            this.tbtNgayLS.Text = "Ngày";
            this.tbtNgayLS.UseVisualStyleBackColor = true;
            // 
            // rbtNamLS
            // 
            this.rbtNamLS.AutoSize = true;
            this.rbtNamLS.Location = new System.Drawing.Point(3, 72);
            this.rbtNamLS.Name = "rbtNamLS";
            this.rbtNamLS.Size = new System.Drawing.Size(47, 17);
            this.rbtNamLS.TabIndex = 6;
            this.rbtNamLS.Text = "Năm";
            this.rbtNamLS.UseVisualStyleBackColor = true;
            // 
            // rbtThangLS
            // 
            this.rbtThangLS.AutoSize = true;
            this.rbtThangLS.Location = new System.Drawing.Point(3, 34);
            this.rbtThangLS.Name = "rbtThangLS";
            this.rbtThangLS.Size = new System.Drawing.Size(56, 17);
            this.rbtThangLS.TabIndex = 5;
            this.rbtThangLS.Text = "Tháng";
            this.rbtThangLS.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(28, 140);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(148, 38);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnLsGdHeThong
            // 
            this.btnLsGdHeThong.Location = new System.Drawing.Point(101, 99);
            this.btnLsGdHeThong.Name = "btnLsGdHeThong";
            this.btnLsGdHeThong.Size = new System.Drawing.Size(90, 23);
            this.btnLsGdHeThong.TabIndex = 3;
            this.btnLsGdHeThong.Text = "Lịch sử GD hệ thống";
            this.btnLsGdHeThong.UseVisualStyleBackColor = true;
            this.btnLsGdHeThong.Click += new System.EventHandler(this.btnLsGdHeThong_Click);
            // 
            // btnLichSuGDtk
            // 
            this.btnLichSuGDtk.Enabled = false;
            this.btnLichSuGDtk.Location = new System.Drawing.Point(101, 62);
            this.btnLichSuGDtk.Name = "btnLichSuGDtk";
            this.btnLichSuGDtk.Size = new System.Drawing.Size(90, 23);
            this.btnLichSuGDtk.TabIndex = 2;
            this.btnLichSuGDtk.Text = "Lịch sử GD TK";
            this.btnLichSuGDtk.UseVisualStyleBackColor = true;
            this.btnLichSuGDtk.Click += new System.EventHandler(this.btnLichSuGDtk_Click);
            // 
            // txbTkTk
            // 
            this.txbTkTk.Location = new System.Drawing.Point(101, 19);
            this.txbTkTk.Name = "txbTkTk";
            this.txbTkTk.Size = new System.Drawing.Size(90, 20);
            this.txbTkTk.TabIndex = 1;
            this.txbTkTk.TextChanged += new System.EventHandler(this.txbTkTk_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên tài khoản";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThayDoiGiaDV);
            this.groupBox3.Controls.Add(this.txbmk);
            this.groupBox3.Controls.Add(this.txbGiaMoi);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.giamoi);
            this.groupBox3.Location = new System.Drawing.Point(251, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(216, 184);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thay đổi giá DV";
            // 
            // btnThayDoiGiaDV
            // 
            this.btnThayDoiGiaDV.Location = new System.Drawing.Point(55, 137);
            this.btnThayDoiGiaDV.Name = "btnThayDoiGiaDV";
            this.btnThayDoiGiaDV.Size = new System.Drawing.Size(106, 29);
            this.btnThayDoiGiaDV.TabIndex = 4;
            this.btnThayDoiGiaDV.Text = "Thay đổi giá DV";
            this.btnThayDoiGiaDV.UseVisualStyleBackColor = true;
            this.btnThayDoiGiaDV.Click += new System.EventHandler(this.btnThayDoiGiaDV_Click);
            // 
            // txbmk
            // 
            this.txbmk.Location = new System.Drawing.Point(89, 59);
            this.txbmk.Name = "txbmk";
            this.txbmk.PasswordChar = '*';
            this.txbmk.Size = new System.Drawing.Size(100, 20);
            this.txbmk.TabIndex = 3;
            // 
            // txbGiaMoi
            // 
            this.txbGiaMoi.Location = new System.Drawing.Point(89, 21);
            this.txbGiaMoi.Name = "txbGiaMoi";
            this.txbGiaMoi.Size = new System.Drawing.Size(100, 20);
            this.txbGiaMoi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mật khẩu";
            // 
            // giamoi
            // 
            this.giamoi.AutoSize = true;
            this.giamoi.Location = new System.Drawing.Point(12, 22);
            this.giamoi.Name = "giamoi";
            this.giamoi.Size = new System.Drawing.Size(42, 13);
            this.giamoi.TabIndex = 0;
            this.giamoi.Text = "Giá mới";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbMKhienTai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnDoiMK);
            this.groupBox1.Controls.Add(this.txbMKnhapLai);
            this.groupBox1.Controls.Add(this.txbMKmoi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt mật khẩu";
            // 
            // txbMKhienTai
            // 
            this.txbMKhienTai.Location = new System.Drawing.Point(117, 25);
            this.txbMKhienTai.Name = "txbMKhienTai";
            this.txbMKhienTai.PasswordChar = '*';
            this.txbMKhienTai.Size = new System.Drawing.Size(96, 20);
            this.txbMKhienTai.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu hiện tại";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Location = new System.Drawing.Point(53, 137);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(106, 29);
            this.btnDoiMK.TabIndex = 2;
            this.btnDoiMK.Text = "Thay đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // txbMKnhapLai
            // 
            this.txbMKnhapLai.Location = new System.Drawing.Point(117, 99);
            this.txbMKnhapLai.Name = "txbMKnhapLai";
            this.txbMKnhapLai.PasswordChar = '*';
            this.txbMKnhapLai.Size = new System.Drawing.Size(96, 20);
            this.txbMKnhapLai.TabIndex = 1;
            // 
            // txbMKmoi
            // 
            this.txbMKmoi.Location = new System.Drawing.Point(117, 65);
            this.txbMKmoi.Name = "txbMKmoi";
            this.txbMKmoi.PasswordChar = '*';
            this.txbMKmoi.Size = new System.Drawing.Size(96, 20);
            this.txbMKmoi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập lại mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu mới";
            // 
            // timerUpdateData
            // 
            this.timerUpdateData.Interval = 3000;
            this.timerUpdateData.Tick += new System.EventHandler(this.timerUpdateData_Tick);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 478);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grbLichSu.ResumeLayout(false);
            this.grbLichSu.PerformLayout();
            this.pnt1.ResumeLayout(false);
            this.pnt1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemTien;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.TextBox txbTenTK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.TextBox txbMKnhapLai;
        private System.Windows.Forms.TextBox txbMKmoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMKhienTai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grbLichSu;
        private System.Windows.Forms.TextBox txbmk;
        private System.Windows.Forms.TextBox txbGiaMoi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label giamoi;
        private System.Windows.Forms.Button btnThayDoiGiaDV;
        private System.Windows.Forms.ListView lsvShow;
        private System.Windows.Forms.Button btnLichSuGDtk;
        private System.Windows.Forms.TextBox txbTkTk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lsvThongKe;
        private System.Windows.Forms.Button btnLsGdHeThong;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.RadioButton tbtNgayLS;
        private System.Windows.Forms.RadioButton rbtNamLS;
        private System.Windows.Forms.RadioButton rbtThangLS;
        private System.Windows.Forms.Panel pnt1;
        private System.Windows.Forms.Timer timerUpdateData;
        private System.Windows.Forms.MaskedTextBox txbSDT;
        private System.Windows.Forms.TextBox txbSoTienThem;
    }
}