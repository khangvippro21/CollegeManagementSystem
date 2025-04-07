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
        protected SqlConnection cn;
        public SqlConnection GetConnection()
        {
            if (cn == null)
            {
                string cnStr = "Data Source=BAOBODOI\\DINHBAO;Initial Catalog=CollegeMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                cn = new SqlConnection(cnStr);
            }
            return cn;
        }

        public DatabaseAccess()
        {
            string cnStr = "Data Source=BAOBODOI\\DINHBAO;Initial Catalog=CollegeMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            cn = new SqlConnection(cnStr);
        }

        protected void Connect()
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
        protected void DisConnect()
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

    }

}
