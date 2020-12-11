using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QLInternetDAL
{
    public class TaiKhoanDAL
    {
        public static TaiKhoan layTaiKhoan(string tentk)
        {
            QLInternetDataContext db = new QLInternetDataContext();
            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK.Trim() == tentk).SingleOrDefault();
            return tk;
        }

        public static void capNhatThongTin(string tentk, string sdt, string email)
        {
            QLInternetDataContext db = new QLInternetDataContext();
            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK.Trim() == tentk).SingleOrDefault();

            //tk.MatKhau = XuLyDAL.maHoaMK(mk);

            if(sdt!="")
                tk.ThongTinTK.SDT = sdt.Replace(" ",string.Empty);
            if(email!="")
                tk.ThongTinTK.Email = email;

            db.SubmitChanges();
        }

        public static List<string> layDsTenTK()
        {
            List<string> danhSach = new List<string>();
            QLInternetDataContext db = new QLInternetDataContext();

            foreach(var i in db.TaiKhoans)
            {
                danhSach.Add(i.TenTK.Trim());
            }
            return danhSach;
        }

        public static List<TaiKhoan> layDsTaiKhoan()
        {
            QLInternetDataContext db = new QLInternetDataContext();

            List<TaiKhoan> danhSachTK = new List<TaiKhoan>();
            foreach(var i in db.TaiKhoans)
            {
                
                danhSachTK.Add(i);
            }
            return danhSachTK;
        }


        public static void upDate_Exit(string tentk, float tgConLai, float tgSuDung)
        { 
            QLInternetDataContext db = new QLInternetDataContext();

            TaiKhoan tk = db.TaiKhoans.Where(p => p.TenTK.Trim() == tentk).SingleOrDefault();
             
            tk.TongTG += tgSuDung;
            tk.TGconLai = tgConLai;
            tk.TrangThai = false;

            db.SubmitChanges();
               
        }

        public static bool ktEmailHopLe(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }


    }
}
