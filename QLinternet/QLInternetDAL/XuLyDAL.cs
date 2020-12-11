using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace QLInternetDAL
{
    public class XuLyDAL
    {

        public static float chuyenChuoiSangFLoat(string k)
        {
            string[] str = k.Split(':');
            float tmp = float.Parse(str[0]) + (float.Parse(str[1])) / 60 + (float.Parse(str[2])) / 3600;
            return tmp;
        }
        public static string chuyenTimeSpanVeString(TimeSpan timetick)
        {
            string gio = timetick.Hours < 10 ? "0" + timetick.Hours.ToString() : timetick.Hours.ToString();
            string phut = timetick.Minutes < 10 ? "0" + timetick.Minutes.ToString() : timetick.Minutes.ToString();
            string giay = timetick.Seconds < 10 ? "0" + timetick.Seconds.ToString() : timetick.Seconds.ToString();

            return gio + ":" + phut + ":" + giay;
        }

        public static string thongKe()
        {
            string k = "";
            QLInternetDataContext db = new QLInternetDataContext();
            double tkNgay = 0, tkThang = 0, tkNam = 0;

            foreach(var i in db.LichSus)
            {
                if (i.NgayGD.Date == DateTime.Now.Date)
                {
                    tkNgay = tkNgay + i.TienThem.Value; 
                }
                if (i.NgayGD.Month == DateTime.Now.Month)
                {
                    tkThang += i.TienThem.Value;
                }
                if (i.NgayGD.Year == DateTime.Now.Year)
                {
                    tkNam += i.TienThem.Value;
                } 
            }

            k = tkNgay.ToString() + "," + tkThang.ToString() + "," + tkNam.ToString();

            return k;
        }
        public static void themTK(string tentk, string mk, float soTienThem)
        {
            QLInternetDataContext db = new QLInternetDataContext(); 

            DichVu giadv = db.DichVus.Where(p => p.TenDV.Trim() == "GiaCuoc").SingleOrDefault();

            TaiKhoan tk = new TaiKhoan();
            ThongTinTK tt = new ThongTinTK();

            tk.MatKhau = maHoaMK(mk);
            tk.TenTK = tentk;
            tk.TongTG = 0;
            tk.TrangThai = false;
             
            tk.TGconLai = soTienThem / giadv.GiaDV;

            LichSu ls = new LichSu();

            ls.TenTK = tentk;
            ls.TienThem = soTienThem;
            ls.NgayGD = DateTime.Now;
            ls.TGThem = soTienThem / giadv.GiaDV;
             
            db.TaiKhoans.InsertOnSubmit(tk);
             
            db.SubmitChanges();

            db.LichSus.InsertOnSubmit(ls);

            db.SubmitChanges();
        }

        public static void doiMatKhau(string tentk ,string mkMoi)
        {
            QLInternetDataContext db = new QLInternetDataContext();
            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == tentk).SingleOrDefault();

            if (tk != null)
            {
                tk.MatKhau = maHoaMK(mkMoi);
                db.SubmitChanges();
            }
        }

        public static bool ktTaiKhoanTonTai(string tentk)
        {
            QLInternetDataContext db = new QLInternetDataContext();
            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == tentk).SingleOrDefault();

            if (tk != null) return true;
            return false;
        }

        public static bool ktKhopMK(string tentk, string mkKiemTra)
        {
            QLInternetDataContext db = new QLInternetDataContext();
            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == tentk).SingleOrDefault();

            if (tk.MatKhau.Trim() == maHoaMK(mkKiemTra))
            {
                return true;
            }
            return false;
        }

        public static void themThongTin(string tenTK, string sdt, string email)
        {
            QLInternetDataContext db = new QLInternetDataContext();
             
            ThongTinTK tttk = new ThongTinTK();
            tttk.TenTK = tenTK;
            if(sdt!="")
                tttk.SDT = sdt;

            if(email!="")
                tttk.Email = email;

            db.ThongTinTKs.InsertOnSubmit(tttk);
            db.SubmitChanges();
        }

        public static void suaThongTin(string tenTK,string matKhau ,string sdt, string email, float soTienThem)
        {
            QLInternetDataContext db = new QLInternetDataContext();

            ThongTinTK tt = db.ThongTinTKs.Where(p => p.TenTK == tenTK).SingleOrDefault();
            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == tenTK).SingleOrDefault();
            DichVu giadv = db.DichVus.Where(p => p.TenDV.Trim() == "GiaCuoc").SingleOrDefault();

            if (tt == null) return;
            else
            { 
                if (matKhau != "") { tk.MatKhau = maHoaMK(matKhau); }

                if(soTienThem!=0)
                    tk.TGconLai = soTienThem / giadv.GiaDV;
               
                tt.SDT = sdt;
                tt.Email = email;
                 
                db.SubmitChanges();
            } 
        }

        public static void themTien(string tentk, float soTienThem)
        {
            QLInternetDataContext db = new QLInternetDataContext();
            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK == tentk).SingleOrDefault();
            DichVu giadv = db.DichVus.Where(p => p.TenDV.Trim() == "GiaCuoc").SingleOrDefault();

            tk.TGconLai += (soTienThem / giadv.GiaDV);

            LichSu ls = new LichSu();
            ls.NgayGD = DateTime.Now;
            ls.TenTK = tentk;
            ls.TienThem = soTienThem;
            ls.TGThem = soTienThem / giadv.GiaDV;

            db.LichSus.InsertOnSubmit(ls);

            db.SubmitChanges();
        }

        public static void xoaTK(string tentk)
        {
            QLInternetDataContext db = new QLInternetDataContext();

            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK.Trim() == tentk).SingleOrDefault();

            ThongTinTK tt = db.ThongTinTKs.Where(p => p.TenTK.Trim() == tentk).SingleOrDefault();
             
            db.ThongTinTKs.DeleteOnSubmit(tt);
            db.TaiKhoans.DeleteOnSubmit(tk);

            db.SubmitChanges(); 
        }
         
        public static string maHoaMK(string mkTho)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(mkTho);
            byte[] mangMaHoa = new MD5CryptoServiceProvider().ComputeHash(temp);
            //var list = mangMaHoa.ToString();
            //list.Reverse();
            string mkMaHoa = "";
            foreach (byte item in mangMaHoa)
            {
                mkMaHoa += item;
            }
            mkMaHoa.Reverse();
            return mkMaHoa;
        }

        public static TaiKhoan dangNhap(string tentk, string mk)
        {
            QLInternetDataContext db = new QLInternetDataContext();
            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK.Trim() == tentk).SingleOrDefault();

            if (tk != null)
            {
                tk.TrangThai = true;
                db.SubmitChanges();
            }
            
            return tk; 
        }
         

        // mk ít nhất 8 kí tự, bao gồm chữ và số
        public static bool ktMatKhauHopLe(string mk)
        {
            if (mk.Length < 8) return false;
            else if (ktKiTu(mk) && ktSo(mk)) return true;
            return false;
        }
        public static bool ktSo(string str)
        {
            foreach (char a in str)
            {
                if (a >= 48 && a <= 57) return true;
            }
            return false;
        }
        public static bool ktKiTu(string str)
        {
            foreach (char a in str)
            {
                if ((a >= 65 && a <= 90) || (a >= 97 && a <= 122)) return true;
            }
            return false;
        }
        //-------        

    }
}
