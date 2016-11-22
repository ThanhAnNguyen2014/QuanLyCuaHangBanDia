using QuanLyCuaHangBanDia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanDia
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormKetNoi());
		}
		public static SqlConnection conn = new SqlConnection();
		public static String connstr;
		public static SqlDataAdapter da;
		public static SqlDataReader myReader;
		public static String servername = ".";
		public static String username;
		public static String password;
		public static String database = "PMQuanLySach";
		public static String mlogin;
		public static String mgroup;
		public static String mten;

		public static SqlDataReader ExecSqlDataReader(String cmd, String connectionstring)
		{
			SqlDataReader myreader;
			SqlCommand sqlcmd = new SqlCommand();
			sqlcmd.Connection = Program.conn;
			sqlcmd.CommandText = cmd;
			sqlcmd.CommandType = CommandType.Text;
			sqlcmd.CommandTimeout = 300;
			if (Program.conn.State == ConnectionState.Closed)
				Program.conn.Open();
			try
			{
				myreader = sqlcmd.ExecuteReader();
				return myreader;
			}
			catch (SqlException e)
			{
				MessageBox.Show("error1" + e.Message);
				Program.conn.Close();
				return null;
			}
		}
		public static DataTable ExecSqlQuery(String cmd, String connectionstring)
		{
			DataTable dt1 = new DataTable();
			conn = new SqlConnection(connectionstring);
			da = new SqlDataAdapter(cmd, conn);
			da.Fill(dt1);
			return dt1;

		}
		public static int ExecSqlNonQuery(String cmd, String connectionstring)
		{
			conn = new SqlConnection(connectionstring);
			SqlCommand Sqlcmd = new SqlCommand();
			Sqlcmd.Connection = conn;
			Sqlcmd.CommandText = cmd;
			Sqlcmd.CommandType = CommandType.Text;
			Sqlcmd.CommandTimeout = 300;
			if (conn.State == ConnectionState.Closed)
				conn.Open();
			try
			{
				Sqlcmd.ExecuteNonQuery();
				conn.Close();
				return 1;
			}
			catch (SqlException)
			{
				conn.Close();
				return 0;
			}
		}

		public static int ketnoi()
		{
			if (Program.conn != null && Program.conn.State == ConnectionState.Open)
				Program.conn.Close();
			try
			{
				Program.connstr = "Data Source=" + Program.servername + "; Initial Catalog=" + Program.database + ";Integrated Security = True; User id=" + Program.mlogin + "; Password=" + Program.password;
				Program.conn.ConnectionString = Program.connstr;
				Program.conn.Open();
				return 1;
			}
			catch (Exception)
			{
				MessageBox.Show("Không thể đăng nhập...", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return 0;
			}
		}
	}

}

