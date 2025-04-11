using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using DataLayer.Khang;

namespace BusinessLayer.Khang
{
    public class RvTble_BL
    {
        public int NumofRview()
        {

            ReviewTble_access a = new ReviewTble_access();
            try
            {
                return a.NumofReview();

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
