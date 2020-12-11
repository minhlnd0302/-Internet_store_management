using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLInternetDTO
{
    public class ThongTinTK_DTO
    {
        public string TenTK { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        public ThongTinTK_DTO(string tentk, string sdt, string email)
        {
            this.TenTK = tentk;
            this.SDT = sdt;
            this.Email = email;
        }
        public ThongTinTK_DTO(string sdt, string email)
        {
            this.SDT = sdt;
            this.Email = email;
        }
    }
}
