using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLInternetDAL
{
    public class ThongTinTK_DAL
    {
        public static List<ThongTinTK> laDsThongTin()
        {
            QLInternetDataContext db = new QLInternetDataContext();

            List<ThongTinTK> n = new List<ThongTinTK>();

            foreach (var i in db.ThongTinTKs)
            {

                i.TenTK = i.TenTK.Trim();
                if(i.SDT!=null)
                    i.SDT = i.SDT.Trim();
                if(i.Email!=null)
                    i.Email = i.Email.Trim();
                n.Add(i);
            }
            return n;

        }

        public static ThongTinTK layThongTintk(string tentk)
        {
            QLInternetDataContext db = new QLInternetDataContext();

            ThongTinTK tt = db.ThongTinTKs.Where(p => p.TenTK.Trim() == tentk).SingleOrDefault();
            return tt;
        }
    }
}
