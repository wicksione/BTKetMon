using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_NCKH;
using DAO;
using DTO;
namespace BLL_NCKH
{
    public class NCKH_BLL
    {
        NCKH_DAL NCKH_DAL = new NCKH_DAL(); 
    }
    public List<DTNC> GetstudentList()
    {
        return NCKH_DAL.readFile("../../../Data/DetaiList");
    }
}
