using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;


namespace BusinessLayer
{
    public class HocphiBL
    {

        private HocphiDAL hocphiDAL;

        public HocphiBL()
        {
            hocphiDAL = new HocphiDAL();
        }

        public List<HocphiDTO> GetAllTuitionInfo()
        {
            return hocphiDAL.GetAllTuitionInfo();
        }

    }
}
