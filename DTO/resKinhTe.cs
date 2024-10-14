using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class resKinhTe:DTNC,IHoTro
    {
        int cauHoiKhaoSat;
        public int CauHoiKhaoSat 
        { 
            get => cauHoiKhaoSat; 
            set => cauHoiKhaoSat = value; 
        }
        public resKinhTe(string maDeTai, string tenDeTai, string chuTriDeTai, string giangvienHD, int cauhoiKS) : base(maDeTai, tenDeTai, chuTriDeTai, giangvienHD)
        {
            this.cauHoiKhaoSat = CauHoiKhaoSat;
        }

        public resKinhTe():base()
        {

        }

        public override double KinhPhiThucHien()
        {
           if(cauHoiKhaoSat > 100)
            {
                return 12000000;
            }
            return 7000000;
        }

        public double kinhphiHoTro()
        {
            if (cauHoiKhaoSat > 100) // Nếu trên 100 câu tính thêm 550đ/câu
            {
                return KinhPhiThucHien() + (cauHoiKhaoSat*550); 
            }
            return KinhPhiThucHien() + (cauHoiKhaoSat * 450); // Các trường hợp còn lại tính 450đ/câu
        }
        public override void xuat()
        {
            base.xuat();
            Console.WriteLine("So luong cau hoi khao sat la : " +CauHoiKhaoSat);
        }
    }
}
