using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLInternetDAL
{
    public class DichVuDAL
    {
        public static void thayDoiGiaDV(float giaMoi)
        {
            QLInternetDataContext db = new QLInternetDataContext();
            //var  n = from GiaDV in db.DichVus select GiaDV;
            //var n = /*from GiaDV in*/ db.DichVus /*select GiaDV*/;
            DichVu dv = db.DichVus.Where(p => p.TenDV == "GiaCuoc").SingleOrDefault();
            if (dv != null)
            {
                dv.GiaDV = giaMoi;
                db.SubmitChanges();
            }
        }

        public static float layGiaDV()
        {
            QLInternetDataContext db = new QLInternetDataContext();
            //var  n = from GiaDV in db.DichVus select GiaDV;
            //var n = /*from GiaDV in*/ db.DichVus /*select GiaDV*/;
            DichVu dv = db.DichVus.Where(p => p.TenDV == "GiaCuoc").SingleOrDefault();
            return float.Parse(dv.GiaDV.ToString());
        }
    }
}
