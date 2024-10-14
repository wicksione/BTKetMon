using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class resCongNghe:DTNC,IHoTro
    {
        string moiTruong;
        public string MoiTruong 
        { 
            get => moiTruong; 
            set => moiTruong = value; 
        }
        public resCongNghe(string maDeTai, string tenDeTai, string chuTriDeTai, string giangvienHD, string moiTruong) : base(maDeTai, tenDeTai, chuTriDeTai, giangvienHD)
        {
            this.MoiTruong = moiTruong;
        }

   

        public override double KinhPhiThucHien()
        {
            if (MoiTruong == "Mobie" || MoiTruong == "Web")
            {
                return 15000000;
            }
            if (MoiTruong == "WinDow")
                {
                    return 10000000; 
                }
            return 0;

        }

        public double kinhphiHoTro()
        {
            if (MoiTruong == "Mobie")
            {
                return KinhPhiThucHien() + 1000000;
            }
            if (MoiTruong == "Web")
            {
                return KinhPhiThucHien() + 800000;
            }
            if (MoiTruong == "WinDow")
            {
                return KinhPhiThucHien() + 500000;
            }
            return KinhPhiThucHien();

        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("moi truong la :" +moiTruong);
        }
    }
}


