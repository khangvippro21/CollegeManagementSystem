using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Khang;

namespace BusinessLayer.Khang
{
    public class LeTble_BL
    {
        public int NumofLe()
        {

            LecturerTble_access a = new LecturerTble_access();
            try
            {
                return a.NumofLecturer();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
