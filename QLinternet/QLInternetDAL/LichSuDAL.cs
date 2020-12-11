using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLInternetDAL
{
    public class LichSuDAL
    {
        public static List<LichSu> layLichSuGD(string tentk)
        {
            QLInternetDataContext db = new QLInternetDataContext();

            List<LichSu> lichSu = new List<LichSu>();

            foreach(var i in db.LichSus)
            {
                if (i.TenTK.Trim() == tentk)
                {
                    lichSu.Add(i);
                }
            }
            return lichSu;

        }
         

        public static List<LichSu> laylsGD(string tentk,string loai)
        {

            QLInternetDataContext db = new QLInternetDataContext();

            List<LichSu> lichSu = new List<LichSu>();

            foreach(var i in db.LichSus)
            {
                if (loai == "tbtNgayLS")
                {
                    if (tentk != "")
                    {
                        if (tentk == i.TenTK.Trim() && i.NgayGD.Date == DateTime.Now.Date)
                        {
                            lichSu.Add(i);
                        } 
                    }
                    else
                    {
                        if (i.NgayGD.Date == DateTime.Now.Date)
                        {
                            lichSu.Add(i);
                        }
                    }
                }
                else if (loai == "rbtThangLS")
                {
                    if (tentk != "")
                    {
                        if (tentk == i.TenTK.Trim() && i.NgayGD.Month == DateTime.Now.Month)
                        {
                            lichSu.Add(i);
                        } 
                    }
                    else
                    {
                        if (i.NgayGD.Month == DateTime.Now.Month)
                        {
                            lichSu.Add(i);
                        }
                    }
                }
                else if (loai == "rbtNamLS")
                {
                    if (tentk != "")
                    {
                        if (tentk == i.TenTK.Trim() && i.NgayGD.Year == DateTime.Now.Year)
                        {
                            lichSu.Add(i);
                        } 
                    }
                    else
                    {
                        if (i.NgayGD.Year == DateTime.Now.Year)
                        {
                            lichSu.Add(i);
                        }
                    }
                }
            }
           
            return lichSu;
        }

    }
}
