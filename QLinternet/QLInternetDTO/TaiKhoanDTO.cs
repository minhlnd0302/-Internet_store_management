using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLInternetDTO
{
    public class TaiKhoanDTO
    {
        public string TenTK { get; set; }
        public string MatKhau { get; set; }
        public bool TrangThai { get; set; }
        public float TongTG { get; set; }
        public float TGconLai { get; set; }

        public TaiKhoanDTO(string tenTk, string matKhau)
        {
            this.TenTK = tenTk;
            this.MatKhau = matKhau;
        }

        public TaiKhoanDTO(string tentk, string matKhau, bool trangthai, float tongtg, float tgconlai)
        {
            this.TenTK = tentk;
            this.MatKhau = matKhau;
            this.TrangThai = trangthai;
            this.TongTG = tongtg;
            this.TGconLai = tgconlai;
        }
    }
}
