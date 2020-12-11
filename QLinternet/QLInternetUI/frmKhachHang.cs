using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLInternetBUS;
using QLInternetDAL;

namespace QLInternetUI
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();

            timerBamGio.Start(); 
        }
        

        private void frmKhachHang_Load(object sender, EventArgs e)
        {

            TaiKhoan tk = TaiKhoanDAL.layTaiKhoan(this.Text);

            txbGiaDV.Text = DichVuDAL.layGiaDV().ToString() + "         đồng/h";
             
            TimeSpan tongTG = LayTimeSpan(tk.TongTG.Value);
            TimeSpan tgConLai = LayTimeSpan(tk.TGconLai.Value);

            txbTGconLai.Text = XuLyDAL.chuyenTimeSpanVeString(tgConLai);

            txbTGsuDung.Text = "00:00:00";
             
            txbTongTG.Text = XuLyDAL.chuyenTimeSpanVeString(tongTG);
             
        }

        public TimeSpan LayTimeSpan(double tmp)
        {
            int soGio = (int)(tmp);
            double soPhut = (tmp - soGio) * 60;
            soPhut = (int)soPhut;
            double soGiay = ((tmp - soGio) * 60 - soPhut) * 60;
            soGiay = (int)soGiay;

            TimeSpan t = new TimeSpan(soGio, (int)soPhut, (int)soGiay);

            return t;
        }

        DateTime timeStart = DateTime.Now;
        public TimeSpan khh = new TimeSpan();

        public int tf = 0;

        private void timerBamGio_Tick(object sender, EventArgs e)
        {
            
            TimeSpan timetick = DateTime.Now - timeStart;
            if (tf == 0)
            {
                khh = LayTimeSpan(TaiKhoanDAL.layTaiKhoan(this.Text).TGconLai.Value);
            }

            tf = 1;
             
            TimeSpan tmp = new TimeSpan(0, 0, 1);

            khh -= tmp;
             
            txbTGsuDung.Text =  XuLyDAL.chuyenTimeSpanVeString(timetick);
            txbTGconLai.Text = XuLyDAL.chuyenTimeSpanVeString(khh);
        }
         
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                float tgConLai = XuLyDAL.chuyenChuoiSangFLoat(txbTGconLai.Text);
                float tgSuDung = XuLyDAL.chuyenChuoiSangFLoat(txbTGsuDung.Text);

                TaiKhoanDAL.upDate_Exit(this.Text, tgConLai, tgSuDung);

                this.Close();
            }
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            ThayDoiTT n = new ThayDoiTT();
            n.Text = this.Text;
            n.Show();
        }
    }
}
