namespace QLInternetUI
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbGiaDV = new System.Windows.Forms.TextBox();
            this.txbTGconLai = new System.Windows.Forms.TextBox();
            this.txbTGsuDung = new System.Windows.Forms.TextBox();
            this.txbTongTG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerBamGio = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbGiaDV);
            this.groupBox1.Controls.Add(this.txbTGconLai);
            this.groupBox1.Controls.Add(this.txbTGsuDung);
            this.groupBox1.Controls.Add(this.txbTongTG);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txbGiaDV
            // 
            this.txbGiaDV.Enabled = false;
            this.txbGiaDV.Location = new System.Drawing.Point(120, 138);
            this.txbGiaDV.Name = "txbGiaDV";
            this.txbGiaDV.Size = new System.Drawing.Size(100, 20);
            this.txbGiaDV.TabIndex = 1;
            // 
            // txbTGconLai
            // 
            this.txbTGconLai.Enabled = false;
            this.txbTGconLai.Location = new System.Drawing.Point(120, 103);
            this.txbTGconLai.Name = "txbTGconLai";
            this.txbTGconLai.Size = new System.Drawing.Size(100, 20);
            this.txbTGconLai.TabIndex = 1;
            // 
            // txbTGsuDung
            // 
            this.txbTGsuDung.Enabled = false;
            this.txbTGsuDung.Location = new System.Drawing.Point(120, 67);
            this.txbTGsuDung.Name = "txbTGsuDung";
            this.txbTGsuDung.Size = new System.Drawing.Size(100, 20);
            this.txbTGsuDung.TabIndex = 1;
            // 
            // txbTongTG
            // 
            this.txbTongTG.Enabled = false;
            this.txbTongTG.Location = new System.Drawing.Point(120, 29);
            this.txbTongTG.Name = "txbTongTG";
            this.txbTongTG.Size = new System.Drawing.Size(100, 20);
            this.txbTongTG.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời gian còn lại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian sử dụng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng thời gian";
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Location = new System.Drawing.Point(33, 215);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(75, 23);
            this.btnThayDoi.TabIndex = 1;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.UseVisualStyleBackColor = true;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(143, 215);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLInternetUI.Properties.Resources.fo4;
            this.pictureBox1.Location = new System.Drawing.Point(7, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timerBamGio
            // 
            this.timerBamGio.Interval = 1000;
            this.timerBamGio.Tick += new System.EventHandler(this.timerBamGio_Tick);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbGiaDV;
        private System.Windows.Forms.TextBox txbTGconLai;
        private System.Windows.Forms.TextBox txbTGsuDung;
        private System.Windows.Forms.TextBox txbTongTG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerBamGio;
    }
}