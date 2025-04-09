using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace DataLayer
{
    public class DatabaseAccess
    {
        private SqlConnection cn;

        public DatabaseAccess()
        {
            //Sua lai default
            string cnStr =
                "Data Source=BAOBODOI\\DINHBAO;Initial Catalog=CollegeMS;Integrated Security=True;TrustServerCertificate=True";
            cn = new SqlConnection(cnStr);
        }

        private void Connect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        private void DisConnect()
        {
            if (cn != null && cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }

        public object MyExecuteScalar(string sql, CommandType type)
        {
            SqlCommand cmd = new SqlCommand(sql, cn);
            Connect();
            try
            {
                return (cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
       public SqlDataAdapter MyAdapterExecute(string sql)
        {
            //Sua lai default
            string cnstr = "Data Source=BAOBODOI\\DINHBAO;Initial Catalog=CollegeMS;Integrated Security=True;TrustServerCertificate=True";
            try 
            {
                return (new SqlDataAdapter(sql, cnstr));
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            
        }


        protected SqlConnection GetConnection()
        {
            return cn;
            
        }

    }

}
