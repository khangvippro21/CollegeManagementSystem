using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer.Khang;
using DataLayer.Khang;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentTble_BL
    {
        public int NumofStd()
        {
            
            StudentTble_access a = new StudentTble_access();
            try 
            {
                return a.NumofStudent();

            } catch (Exception e) 
            {
                throw e;
            }
        }
    }
}
