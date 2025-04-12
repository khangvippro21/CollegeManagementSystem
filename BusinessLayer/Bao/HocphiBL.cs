using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
using System.Data;
using System.Data.SqlClient;



namespace BusinessLayer
{
    public class HocphiBL
    {

        HocphiDAL hocphiDAL = new HocphiDAL();

        public DataTable gethocphi()
        {
            return hocphiDAL.gethocphi(); 
        }

        public DataTable GetFeeDataByCourse()
        {
            
            return hocphiDAL.GetTotalFeeByCourse();
        }

    }
}
