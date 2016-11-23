using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLayer
{
    public class DAL
    {
		string ConnStr= "Data Source=192.168.1.2;Initial Catalog=QLCuaHangDia;User ID=sa;Password=123";

		SqlConnection conn = null;
		SqlCommand comm = null;
		SqlDataAdapter da = null;
		public DAL()
		{
			conn = new SqlConnection(ConnStr);
			comm = conn.CreateCommand();
		}
		public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[]p)
		{
			if (conn.State == ConnectionState.Open)
				conn.Close();
			conn.Open();
			comm.CommandText = strSQL;
			comm.CommandType = ct;
			da = new SqlDataAdapter(comm);
			DataSet ds = new DataSet();
			da.Fill(ds);
			return ds;
		}
		public bool MyExecuteNonQuery(string strSQL, CommandType ct, 
			ref string error, params SqlParameter[] param)
		{
			bool flag = false;
			if (conn.State == ConnectionState.Open)
				conn.Close();
			conn.Open();
			comm.Parameters.Clear();
			comm.CommandText = strSQL;
			comm.CommandType = ct;
			foreach (SqlParameter p in param)
				comm.Parameters.Add(p);
			try
			{
				comm.ExecuteNonQuery();
				flag = true;
			}
			catch (SqlException ex)
			{
				error = ex.Message;
			}
			finally
			{
				conn.Close();
			}
			return flag;
		}
		public string MyExecuteScalar(string sqlString, CommandType ct, 
			ref string err, params SqlParameter[] p)
		{
			string temp = "";
			if (conn.State == ConnectionState.Open)
				conn.Close();
			conn.Open();
			comm.Parameters.Clear();
			comm.CommandText = sqlString;
			comm.CommandType = ct;
			foreach (SqlParameter i in p)
			{
				comm.Parameters.Add(i);
			}
			try
			{
				temp = (string)comm.ExecuteScalar();
			}
			catch (SqlException e)
			{
				err = e.Message;
			}
			finally
			{
				conn.Close();
			}
			return temp;
		}


	}
}
