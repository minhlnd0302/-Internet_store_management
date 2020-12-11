using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLInternetDAL;
using QLInternetDTO;


namespace QLInternetBUS
{
    public class XuLuTK_BUS
    {
        public static bool dangNhap(string tentk, string mk)
        {
            if (mk == "") return false;

            TaiKhoan tk = XuLyDAL.dangNhap(tentk, mk);
            if (tk == null)
            {
                return false;
            }
            else if (tk.TenTK.Trim() != tentk || tk.MatKhau.Trim() != mk) return false;
            tk.TrangThai = true;
            return true;
        }

        public static string doiMK(string tentk,string mkCu ,string mkMoi,string mkNhapLai)
        {
             
            if (!XuLyDAL.ktKhopMK(tentk, mkCu))
            {
                return "kkmk";
            }
            else if (!XuLyDAL.ktMatKhauHopLe(mkMoi))
            {
                return "mkKhongHopLe";
            }
            else if (mkMoi != mkNhapLai)
            {
                return "KhacMKnhapLai";
            }
            return "ok";

        }

        public static bool suaThongTin(string tentk, string mk)
        {
            if (!XuLyDAL.ktMatKhauHopLe(mk)) return false;
            return true;
        }

        public static bool xoaTK(string tenTK)
        {

            if (tenTK == "")
                return false;
            return true; 
        }

        public static bool themTK(string tenTK)
        {
            TaiKhoan tk = TaiKhoanDAL.layTaiKhoan(tenTK);

            if (tk != null) return false;
            return true;
        }

        public static bool themTien(string tentk ,float soTienThem)
        {
            if (soTienThem > 0)
            {
                XuLyDAL.themTien(tentk, soTienThem);
                return true;
            }
            return false;
        }

    }
}
