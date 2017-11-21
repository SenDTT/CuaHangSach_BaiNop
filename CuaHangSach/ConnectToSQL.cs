using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CuaHangSach
{
    public class ConnectToSQL
    {
        protected SqlConnection cn = null;
        protected SqlCommand cmd = new SqlCommand();
        protected string cnstr = null;


        public ConnectToSQL()
        {
            cnstr = ConfigurationManager.ConnectionStrings["Cua_Hang_Sach"].ConnectionString;
            cn = new SqlConnection(cnstr);
        }


        public void Connect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Closed)
                    cn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void DisConnect()
        {
            if ((cn != null) && (cn.State != ConnectionState.Closed))
            {
                cn.Close();
            }
        }

        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            try
            {
                this.Connect();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                this.DisConnect();
            }
            return dt;
        }

        public bool SetData(string sql)
        {
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cn;
            try
            {
                this.Connect();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                this.DisConnect();
            }
            return false;
        }
    }
}
