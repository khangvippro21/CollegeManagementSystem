using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TransferObject;
using System.Security.Cryptography.X509Certificates;

namespace DataLayer
{
    public class DatabaseAccess
    {
        public SqlConnection cn;

        public DatabaseAccess()
        {
            string cnStr = "Data Source=BAOBODOI\\DINHBAO;Initial Catalog=CollegeMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                
            cn = new SqlConnection(cnStr);
        }

        public void Connect()
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
        public void DisConnect()
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
            //string cnstr = "Data Source=BAOBODOI\\DINHBAO;Initial Catalog=CollegeMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            try
            {
                return (new SqlDataAdapter(sql, cn));
            }
            catch (SqlException ex)
            {
                throw ex;
            }   
        }
       
        public int MyExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                Connect();
                cmd.Connection = cn;
                return cmd.ExecuteNonQuery();
               
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect() ;
            }
            
        }  
    }
}
