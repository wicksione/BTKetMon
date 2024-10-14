using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class DTNC
    {
        private string maDeTai;
        private string tenDeTai;
        private string chuTriDeTai;
        private string giangvienHD;

        public DTNC()
        {
            this.MaDeTai = "";
            this.TenDeTai = "";
            this.ChuTriDeTai = "";
            this.GiangvienHD = "";
        }
        public DTNC(string maDeTai, string tenDeTai, string chuTriDeTai, string giangvienHD)
        {
            this.MaDeTai = maDeTai;
            this.TenDeTai = tenDeTai;
            this.ChuTriDeTai = chuTriDeTai;
            this.GiangvienHD = giangvienHD;
        }

        public string MaDeTai { get => maDeTai; set => maDeTai = value; }
        public string TenDeTai { get => tenDeTai; set => tenDeTai = value; }
        public string ChuTriDeTai { get => chuTriDeTai; set => chuTriDeTai = value; }
        public string GiangvienHD { get => giangvienHD; set => giangvienHD = value; }

        public abstract double KinhPhiThucHien();


        public virtual void xuat()
        {
            Console.WriteLine("{0}/n {1}/n {2}/n {3}/n",maDeTai,tenDeTai,chuTriDeTai,giangvienHD);
        }
    }
}