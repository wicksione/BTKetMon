using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class resLyThuyet:DTNC
    {
        bool apDungThucTe;

        public resLyThuyet(string maDeTai, string tenDeTai, string chuTriDeTai, string giangvienHD, bool apdungthucte) : base(maDeTai, tenDeTai, chuTriDeTai, giangvienHD)
        {      
            this.apDungThucTe = apdungthucte;
        }

        public bool Apdungthucte 
        { 
            get => apDungThucTe; 
            set => apDungThucTe = value; 
        }

        public override double KinhPhiThucHien()
        {
            if (Apdungthucte == true)
            {
                return 15000000;
            }
                return 8000000;
        }
        public override void xuat()
        {
            base.xuat();
        }
    }
}
