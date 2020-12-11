using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLInternetDAL;
using QLInternetBUS;

namespace QLInternetUI
{
    public partial class ThayDoiTT : Form
    {
        public ThayDoiTT()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = TaiKhoanDAL.layTaiKhoan(this.Text);
            //if (tk.MatKhau.Trim() != XuLyDAL.maHoaMK(txbMKhienTai.Text))
            //{
            //    MessageBox.Show("Mật khẩu hiện tại không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //if (!XuLyDAL.ktMatKhauHopLe(txbMKmoi1.Text))
            //{
            //    MessageBox.Show("                          Mật khẩu không hợp lệ \n ( Mật khẩu phải có ít nhất 8 kí tự, phải bao gồm cả chữ và số)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}

            //if (txbMKmoi1.Text != txbMKmoi2.Text)
            //{
            //    MessageBox.Show("Mật khẩu mới nhập lại không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            if (txbEmail.Text != "")
            {
                if (!TaiKhoanDAL.ktEmailHopLe(txbEmail.Text))
                {
                    MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            TaiKhoanDAL.capNhatThongTin(this.Text, txbSDT.Text.Replace(" ",string.Empty), txbEmail.Text);
            MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();


        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            TaiKhoan tk = TaiKhoanDAL.layTaiKhoan(this.Text);
            if (tk.MatKhau.Trim() != XuLyDAL.maHoaMK(txbMKhienTai.Text))
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!XuLyDAL.ktMatKhauHopLe(txbMKmoi1.Text))
            {
                MessageBox.Show("                          Mật khẩu không hợp lệ \n ( Mật khẩu phải có ít nhất 8 kí tự, phải bao gồm cả chữ và số)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txbMKmoi1.Text != txbMKmoi2.Text)
            {
                MessageBox.Show("Mật khẩu mới nhập lại không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            XuLyDAL.doiMatKhau(this.Text, txbMKmoi1.Text);

            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
