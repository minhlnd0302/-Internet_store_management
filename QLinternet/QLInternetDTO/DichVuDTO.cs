using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLInternetDTO
{
    public class DichVuDTO
    {
        public float GiaDV { get; set; }
        public string loaiDV { get; set; }
        public DichVuDTO(string loaidv, float giaDV)
        {
            this.GiaDV = giaDV;
            this.loaiDV = loaidv;
        }
    }
}
