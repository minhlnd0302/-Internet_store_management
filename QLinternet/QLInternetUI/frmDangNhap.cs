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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
            txbMatKhau.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            

            if (txbMatKhau.Text == "" || txbTenTK.Text == "")
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tentk = txbTenTK.Text;


            string matKhau = XuLyDAL.maHoaMK(txbMatKhau.Text);
            if (XuLuTK_BUS.dangNhap(tentk, matKhau))
            {
                this.Dispose(false);
                if (tentk == "admin")
                { 
                    frmAdmin n = new frmAdmin();
                    n.Text = tentk;
                    n.Show();
                    
                }
                else
                {
                    frmKhachHang n = new frmKhachHang();
                    n.Text = tentk;
                    n.Show();
                }
            }
            else
            {
                txbTenTK.Text = "";
                txbMatKhau.Text = "";
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //string k = XuLyDAL.maHoaMK("admin123");

            txbMatKhau.Text = "";
            txbTenTK.Text = "";

            
        }
    }
}
