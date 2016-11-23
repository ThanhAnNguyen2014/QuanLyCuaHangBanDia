using BALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanDia
{
	public partial class Login : Form
	{
        public static SqlConnection conn;
        public static string strConnectionString;
        public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        public static string servername;
        public static string username;
        public static string password;
        public static string database;
        public static string mlogin;
        public static string mgroup;
        public static string mten;

		public static string nhom;
		public static string ten;
		public static string kt;
		public string diachiid;
		public string tencsdl;
		DBKTTaiKhoan dbkttk;
		public Login()
		{
			InitializeComponent();
			dbkttk = new DBKTTaiKhoan();
			Login_Load();
		}
		private void Login_Load()
		{
            txtid.Focus();

			//try
			//{
   //             //string strConnectionString = "Data Source=.;Initial Catalog=QLCuaHangDia;Integrated Security=True";
   //             connstr = "Data Source=" + diachiid + ";Initial Catalog=" + tencsdl + ";Integrated Security=False;User ID=" + username + ";Password=" + password;
   //         SqlConnection   con = new SqlConnection(connstr);
   //             if (con.State == ConnectionState.Open) con.Close();
   //             con.Open();
   //           SqlCommand  com = new SqlCommand();
   //             com.Connection = con;
   //             btnLogin.Enabled = false;
				
			//}
			//catch (SqlException ex)
			//{
			//	MessageBox.Show("Error: " + ex.Message);
			//	txtcsdl.Focus();
			//}
		}
		private void btnExit_Click(object sender, EventArgs e)
		{
			DialogResult traloi;
			traloi = MessageBox.Show("Chắc không?", "Trả lời",
			MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (traloi == DialogResult.OK)
				Application.Exit();
		}
		private void btnLogin_Click(object sender, EventArgs e)
		{
            username = txtUser.Text;
            ten = txtUser.Text;
            diachiid = txtid.Text;
            tencsdl = txtcsdl.Text;
            password = txtPass.Text;
            servername = txtid.Text;
            database = txtcsdl.Text;
			
			if (ketnoi() == 0)
			{
				txtUser.ResetText();
				txtPass.ResetText();
				txtid.Focus();

				return;
			}
			//kiểm tra user
			//String strlenh = "SELECT loginname from sys.syslogins where sid= suser_sID('" + program.mlogin + "')";
			String strlenh = "SELECT name from sys.sysusers where sid= suser_sID('" + mlogin + "')";
			myReader = ExecSqlDataReader(strlenh, strConnectionString);
			myReader.Read();
			username = myReader.GetString(0);//lay username
			if (Convert.IsDBNull(username))
			{
				MessageBox.Show("error3", "", MessageBoxButtons.OK);
				txtUser.Focus();
				return;
			}
			myReader.Close();
			strlenh = "sp_helpuser '" + username + "'";// trả về các field username groupname loginname dbname userID sid
			try
			{
				myReader =ExecSqlDataReader(strlenh, strConnectionString);
			}
			catch (InvalidOperationException)
			{
				MessageBox.Show("error2", "", MessageBoxButtons.OK);
				return;
			}
			//lấy groupname 
			if (myReader.Read())
			{
				mgroup = myReader.GetString(1);
				nhom = mgroup;
			}
			else
			{
				MessageBox.Show("error1", "", MessageBoxButtons.OK);
				return;
			}
			myReader.Close();
			//lấy ten của user. kiểm tra có chủ tài khoản là ai
			if (nhom == "staff")
			{

				strlenh = "select TenNV from NhanVien where MaNV ='" + username + "'";

			}
			if (nhom == "director")
			{
				strlenh = "select HoTen from GiamDoc where MaGD ='" + username + "'";
			}
			if (nhom == "manager")
			{
				strlenh = "select HoTenQL from QuanLy where MaQL ='" + username + "'";
			}
			myReader = ExecSqlDataReader(strlenh, strConnectionString);
			if (myReader.HasRows)
			{
				myReader.Read();
				mten = myReader.GetString(0);
				ten = mten;
			}
			else
			{
				MessageBox.Show("Error Không có thông tin người này", " ", MessageBoxButtons.OK);
				myReader.Close();
				conn.Close();
				return;
			}
			myReader.Close();
			strlenh = "select TrangThai from CapNhatTaiKhoan where TenLogin ='" + username + "'";
			myReader = ExecSqlDataReader(strlenh, strConnectionString);
			if (myReader.HasRows)
			{
                myReader.Read();
                kt = myReader.GetString(0);
			}
			if (kt == "0")
			{
				string err = "";
				bool f = dbkttk.CapNhatTK(ref err, username, "1");
				conn.Close();
                Form main = new Form1();
                main.Show();
			}
			if (kt == "1")
			{
				MessageBox.Show("Tai Khoan Da Dang Nhap", " ", MessageBoxButtons.OK);
				myReader.Close();
				conn.Close();
				return;
			}
		}
		private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				txtPass.Focus();
		}

		private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				btnLogin.Focus();
		}
        //private void button5_Click(object sender, EventArgs e)
        //{
        //	diachiid = txtid.Text;
        //	username = txtUser.Text;
        //	password = txtPass.Text;
        //	tencsdl = txtcsdl.Text;
        //	strConnectionString = "Data Source=" + diachiid + ";Initial Catalog=" + tencsdl + ";Integrated Security=False;User ID=" + username + ";Password=" + password;

        //	if (diachiid.Equals("") || username.Equals("") || password.Equals("") || tencsdl.Equals(""))
        //	{
        //		MessageBox.Show("Thiếu thông tin! bạn cần điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //	}
        //	else
        //	{
        //		try
        //		{
        //			SqlConnection myConnection = new SqlConnection(strConnectionString);
        //			myConnection.Open();
        //			MessageBox.Show("Kết nối Thành Công!");
        //                  //myConnection.Close();
        //                  btnLogin.Enabled = true;
        //                  button5.Enabled = false;

        //              }
        //		catch
        //		{
        //			MessageBox.Show("Kết Nối Không Thành Công!!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //			Application.Exit();
        //		}
        //	}


        //}


        public  SqlDataReader ExecSqlDataReader(String cmd, String connectionstring)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.Connection = conn;
            sqlcmd.CommandText = cmd;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 3000;
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader();
                return myreader;
            }
            catch (SqlException e)
            {
                MessageBox.Show("error1" + e.Message);
                conn.Close();
                return null;
            }
        }
        public  DataTable ExecSqlQuery(String cmd, String connectionstring)
        {
            DataTable dt1 = new DataTable();
            conn = new SqlConnection(connectionstring);
            da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt1);
            return dt1;

        }
        public  int ExecSqlNonQuery(String cmd, String connectionstring)
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

        public int ketnoi()
        {
            if (conn != null && conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                 strConnectionString = "Data Source=" + diachiid + ";Initial Catalog=" + database + ";Integrated Security=false;User ID=" + username + ";Password=" + password;
                conn = new SqlConnection(strConnectionString);
                conn.Open();
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
