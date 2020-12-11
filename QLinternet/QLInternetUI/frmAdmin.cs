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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();

            showData();

            timerUpdateData.Start();
             
        }
         
        public void showData()
        {
            lsvShow.FullRowSelect = true;

            lsvShow.Columns.Add("TenTK");
            lsvShow.Columns.Add("SĐT");
            lsvShow.Columns.Add("Email");
            lsvShow.Columns.Add("Tổng TG");
            lsvShow.Columns.Add("TG còn lại");
            lsvShow.Columns.Add("Trạng Thái");

            List<TaiKhoan> dsTaiKhoan = TaiKhoanDAL.layDsTaiKhoan();
            List<ThongTinTK> dsThongTin = ThongTinTK_DAL.laDsThongTin();

            for (int i = 0; i < dsTaiKhoan.Count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dsTaiKhoan[i].TenTK.Trim();

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dsThongTin[i].SDT });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dsThongTin[i].Email });

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dsTaiKhoan[i].TongTG.ToString() + " giờ" });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = dsTaiKhoan[i].TGconLai.ToString() + " giờ" });

                string trangThai = "Online";
                if (dsTaiKhoan[i].TrangThai == false) trangThai = "Ofline";

                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = trangThai });
                lsvShow.Items.Add(item);

            }

        } 

        private void ShowLichSuTK(string tentk)
        {
            lsvThongKe.FullRowSelect = true;

            string dk = layYeuLichSu(/*grbLichSu*/pnt1);

            List<LichSu> ls = LichSuDAL.laylsGD(tentk, dk);

            if (tentk != "")
            {
                lsvThongKe.Columns.Add("Thời gian");
                lsvThongKe.Columns.Add("Tiền thêm");
                lsvThongKe.Columns.Add("TG thêm");

                //List<LichSu> ls = LichSuDAL.layLichSuGD(txbTkTk.Text);

                for (int i = ls.Count - 1; i >= 0; i--)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = ls[i].NgayGD.ToString();

                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ls[i].TienThem.ToString() + " đồng" });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ls[i].TGThem.ToString() + " giờ" });

                    lsvThongKe.Items.Add(item);
                }
            }
            else
            {
                lsvThongKe.Columns.Add("Tên tài khoản");
                lsvThongKe.Columns.Add("Thời gian");
                lsvThongKe.Columns.Add("Tiền thêm");
                lsvThongKe.Columns.Add("Thời gian thêm");

                // List<LichSu> ls = LichSuDAL.laylsGDtrongNgay();

                for (int i = ls.Count - 1; i >= 0; i--)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = ls[i].TenTK.Trim();

                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ls[i].NgayGD.ToString() });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ls[i].TienThem.ToString() + " đồng" });
                    item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = ls[i].TGThem.ToString() + " giờ" });

                    lsvThongKe.Items.Add(item);
                }
            }
        }



        string yeuCau = "";

        private void autocomplete(TextBox txbTenTK)
        {
            List<string> str = TaiKhoanDAL.layDsTenTK();

            txbTenTK.Enabled = true;

            txbTenTK.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txbTenTK.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var n = new AutoCompleteStringCollection();

            n.AddRange(str.ToArray());

            txbTenTK.AutoCompleteCustomSource = n;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            //List<TaiKhoan> n = TaiKhoanDAL.layDsTaiKhoan();

            //string k = XuLyDAL.maHoaMK("admin123");


            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            trangThaiBanDau();
            yeuCau = "THEM_TK";

            txbTenTK.AutoCompleteMode = AutoCompleteMode.None;
            txbTenTK.AutoCompleteSource = AutoCompleteSource.None;


            txbTenTK.Enabled = true;
            txbMatKhau.Enabled = true;
            txbSDT.Enabled = true;
            txbEmail.Enabled = true;
            txbSoTienThem.Enabled = true;

            btnHuyBo.Enabled = true;
            btnThucHien.Enabled = true;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            yeuCau = "";
            trangThaiTextBoxBanDau();
            trangThaiBanDau();
        }

        private void trangThaiBanDau()
        {
            txbTenTK.Enabled = false;
            txbMatKhau.Enabled = false;
            txbSDT.Enabled = false;
            txbEmail.Enabled = false;
            txbSoTienThem.Enabled = false;

            btnHuyBo.Enabled = false;
            btnThucHien.Enabled = false;
        }

        private void btnThemTien_Click(object sender, EventArgs e)
        {
            //string[] str = { "minh", "minh" };
            //txbTenTK.AutoCompleteCustomSource = str;
            //XuLyDAL.themTien("admin", 10000);

            autocomplete(txbTenTK);

            trangThaiBanDau();
            yeuCau = "THEM_TIEN";



            txbTenTK.Enabled = true;
            txbSoTienThem.Enabled = true;

            btnHuyBo.Enabled = true;
            btnThucHien.Enabled = true;
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            trangThaiBanDau();
            yeuCau = "XOA";

            autocomplete(txbTenTK);

            txbTenTK.Enabled = true;

            btnHuyBo.Enabled = true;
            btnThucHien.Enabled = true;
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            trangThaiBanDau();
            yeuCau = "CHINH_SUA";

            autocomplete(txbTenTK);

            txbTenTK.Enabled = true;
            txbMatKhau.Enabled = true;
            txbSDT.Enabled = true;
            txbEmail.Enabled = true;
            txbSoTienThem.Enabled = true;

            btnHuyBo.Enabled = true;
            btnThucHien.Enabled = true;
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (yeuCau == "XOA")
            {
                if (txbTenTK.Text == "admin")
                {
                    MessageBox.Show("Bạn không thể xóa tài khoản quản lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (XuLuTK_BUS.xoaTK(txbTenTK.Text) == false)
                    {
                        MessageBox.Show("Tài khoản không tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (XuLuTK_BUS.xoaTK(txbTenTK.Text))
                    {
                        if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa tài khoản này ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                        {
                            XuLyDAL.xoaTK(txbTenTK.Text);

                            //trangThaiBanDau();
                            MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            trangThaiTextBoxBanDau();
                            trangThaiBanDau();
                        }
                    }
                }
            }
            else if (yeuCau == "THEM_TK")
            {
                if (txbTenTK.Text == "")
                {
                    MessageBox.Show("Tên tài khoản không được bỏ trống !", "Chú ý !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnThemTK_Click(sender, e);
                    return;
                }

                else if (txbMatKhau.Text == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống !", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!XuLuTK_BUS.themTK(txbTenTK.Text))
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    if (XuLyDAL.ktMatKhauHopLe(txbMatKhau.Text))
                    {

                        float tienThem = 0;

                        if (txbSoTienThem.Text.Replace(" ", string.Empty) != "")
                        {
                            tienThem = float.Parse(txbSoTienThem.Text.Replace(" ", string.Empty));
                        }

                        if (txbSDT.Text.Trim() != "")
                        {
                            if(txbSDT.Text.Replace(" ", string.Empty).Length != 10)
                            {
                                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }

                        //if(txbSDT.Text)

                        if (txbEmail.Text != "")
                        {
                            if (!TaiKhoanDAL.ktEmailHopLe(txbEmail.Text))
                            {
                                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }


                        XuLyDAL.themTK(txbTenTK.Text, /*XuLyDAL.maHoaMK(txbMatKhau.Text)*/ txbMatKhau.Text, tienThem);

                        
                        XuLyDAL.themThongTin(txbTenTK.Text, txbSDT.Text.Replace(" ", string.Empty), txbEmail.Text);

                       

                        MessageBox.Show("Tài khoản đã được thêm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        trangThaiTextBoxBanDau();
                        trangThaiBanDau();
                    }
                    else
                    {
                        MessageBox.Show("                          Mật khẩu không hợp lệ \n ( Mật khẩu phải có ít nhất 8 kí tự, phải bao gồm cả chữ và số)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }

            }
            else if (yeuCau == "CHINH_SUA")
            {

                if (XuLuTK_BUS.suaThongTin(txbTenTK.Text, txbMatKhau.Text))
                {
                    float tienThem = 0;
                    if (txbSoTienThem.Text.Replace(" ", string.Empty) != "")
                    {
                        tienThem = float.Parse(txbSoTienThem.Text.Replace(" ", string.Empty));
                    }

                    if (txbSDT.Text.Trim() != "")
                    {
                        if (txbSDT.Text.Replace(" ", string.Empty).Length != 10)
                        {
                            MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    //if(txbSDT.Text)

                    if (txbEmail.Text != "")
                    {
                        if (!TaiKhoanDAL.ktEmailHopLe(txbEmail.Text))
                        {
                            MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    XuLyDAL.suaThongTin(txbTenTK.Text, txbMatKhau.Text, txbSDT.Text.Replace(" ", string.Empty), txbEmail.Text, tienThem);

                    MessageBox.Show("Chỉnh sữa hoàn tất !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    trangThaiTextBoxBanDau();
                    trangThaiBanDau();

                }
                else
                {
                    MessageBox.Show("Mật khẩu không hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (yeuCau == "THEM_TIEN")
            {
                float tienThem = 0;
                if (txbSoTienThem.Text.Replace(" ", string.Empty) != "")
                {
                    tienThem = float.Parse(txbSoTienThem.Text.Replace(" ", string.Empty));
                    XuLyDAL.themTien(txbTenTK.Text, tienThem);
                    trangThaiBanDau();
                    trangThaiTextBoxBanDau();
                    MessageBox.Show("Nạp tiền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            yeuCau = "";

            lsvShow.Clear();
            showData();

        }

        private void trangThaiTextBoxBanDau()
        {
            txbEmail.Text = "";
            txbMatKhau.Text = "";
            txbSDT.Text = "";
            txbTenTK.Text = "";
            txbSoTienThem.Text = "";
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txbMKhienTai.Text == "" || txbMKmoi.Text == "" || txbMKnhapLai.Text == "")
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string str = XuLuTK_BUS.doiMK(this.Text, txbMKhienTai.Text, txbMKmoi.Text, txbMKnhapLai.Text);

            if (str == "kkmk")
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (str == "mkKhongHopLe")
            {
                MessageBox.Show("Mật khẩu mới không hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (str == "KhacMKnhapLai")
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                XuLyDAL.doiMatKhau(this.Text, txbMKmoi.Text);
                txbMKhienTai.Text = "";
                txbMKmoi.Text = "";
                txbMKnhapLai.Text = "";
                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThayDoiGiaDV_Click(object sender, EventArgs e)
        {
            float giamoi;
            float.TryParse(txbGiaMoi.Text, out giamoi);
            if (txbmk.Text == "")
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (giamoi != 0)
            {
                if (XuLyDAL.ktKhopMK(this.Text, txbmk.Text))
                {
                    DichVuDAL.thayDoiGiaDV(giamoi);
                    MessageBox.Show("Thay đổi giá dịch vụ thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txbGiaMoi.Text = "";
                    txbmk.Text = "";
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void lsvShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            if (lsv.SelectedItems.Count == 1)
            {
                ListViewItem item = lsv.SelectedItems[0];
                txbTenTK.Text = item.Text;
            }

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            autocomplete(txbTkTk);

        }
         
      
        private void txbTkTk_TextChanged(object sender, EventArgs e)
        {
            if (txbTkTk.Text == "")
            {
                btnLichSuGDtk.Enabled = false;
            }
            else btnLichSuGDtk.Enabled = true;
        }

        public string layYeuLichSu(  Panel p)
        {
            foreach (RadioButton item in  p.Controls )
            {
                if (item.Checked)
                {
                    return item.Name;
                }
            }
            return "tbtNgayLS";
        }

      
        private void btnLichSuGDtk_Click(object sender, EventArgs e)
        {
            lsvThongKe.Clear();
            ShowLichSuTK(txbTkTk.Text);
        }

        private void btnLsGdHeThong_Click(object sender, EventArgs e)
        {
            lsvThongKe.Clear();

            //ShowlsGDtrongNgay();

            ShowLichSuTK("");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            lsvThongKe.Clear();

            string[] str = XuLyDAL.thongKe().Split(',');

            lsvThongKe.Columns.Add("Doanh thu ngày");
            lsvThongKe.Columns.Add("Danh thu tháng");
            lsvThongKe.Columns.Add("Doanh thu năm");


            ListViewItem item = new ListViewItem();
            item.Text = str[0] + " đồng";

            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = str[1]+" đồng" });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = str[2] + " đồng" });

            lsvThongKe.Items.Add(item); 

        }

        private void timerUpdateData_Tick(object sender, EventArgs e)
        {
            lsvShow.Clear();
            showData();
        }

        
    }
}
