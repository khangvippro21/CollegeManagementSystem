using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Khang;

namespace BusinessLayer.Khang
{
    public class CoTble_BL
    {
        public int NumofCourse()
        {

            CourseTble_access a = new CourseTble_access();
            try
            {
                return a.NumofCourse();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
