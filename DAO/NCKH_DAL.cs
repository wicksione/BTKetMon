using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DTO;

namespace DAL_NCKH
{
    public class NCKH_DAL
    {

        List<DTNC> _lstdeTai = new List<DTNC>();
        private DTNC dt;


        List<DTNC> lstdeTai;

        public List<DTNC> LstdeTai { get => lstdeTai; set => lstdeTai = value; }

        public NCKH_DAL()
        {
            LstdeTai = new List<DTNC>();
        }
        public NCKH_DAL(List<DTNC> lstdeTai)
        {
            lstdeTai = lstdeTai;    
        }
       
        public void ReadFile(string filename)
        {
            Console.InputEncoding = UnicodeEncoding.Unicode;
           
            
                XmlDocument read = new XmlDocument();
                read.LoadXml(filename);
                XmlNodeList nodeList = read.SelectNodes("DeTaiList/DeTai");

                foreach (XmlNode node in nodeList)
                {
                    DTNC dt;
                    int loai = int.Parse(node["loai"].InnerText);
                    string maDeTai = node["maDeTai"].InnerText;
                    string tenDeTai = node["tenDeTai"].InnerText;
                    string chuTriDeTai = node["chuTriDeTai"].InnerText;
                    string giangVienHD = node["giangVienHD"].InnerText;              
                    if(loai == 1 )
                    {
                        bool apDungThucTe = true;
                        dt = new DTNC(maDeTai, tenDeTai, chuTriDeTai, giangVienHD);
                        lstStudent.Add(dt);
                    }
                    if (loai == 2)
                    {
                        int cauHoiKhaoSat = int.Parse(node["cauHoiKhaoSat"].InnerText);
                        dt = new DTNC(maDeTai, tenDeTai, chuTriDeTai, giangVienHD);
                        lstStudent.Add(dt);
                    }
                    if(loai == 3)
                    {
                        string MoiTruong = node["MoiTruong"].InnerText;
                        dt = new DTNC(maDeTai, tenDeTai, chuTriDeTai, giangVienHD);
                        lstStudent.Add(dt);
                    }

                }
            
           

        }
        public resKinhTe inds100cau()
        {
            resKinhTe indanhsach = new resKinhTe();
            foreach (var dt in LstdeTai)
            {
                if(dt.c)
            }
            
        }
        public void xuat()
        {
            Console.WriteLine("Thong tin de tai thu {0}: ", LstdeTai.IndexOf(dt) + 1);
            if(dt is resLyThuyet lt)
            {
                lt.xuat();
            }
            if(dt is resCongNghe cn)
            {
                cn.xuat();
            }
            if(dt is resKinhTe kt)
            {
                kt.xuat();
            }
        }
    }
}

