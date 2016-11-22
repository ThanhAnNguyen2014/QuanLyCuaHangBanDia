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
		string strConnectionString = "Data Source=.;Initial Catalog=PMQuanLySach;Integrated Security=True";
		SqlConnection con = null;
		SqlCommand com;
		public static string nhom;
		public static string ten;
		public static string kt;
		DBKTTaiKhoan dbkttk;
		public Login()
		{
			InitializeComponent();
			dbkttk = new DBKTTaiKhoan();
			Login_Load();
		}
		private void Login_Load()
		{

			try
			{
				con = new SqlConnection(strConnectionString);
				if (con.State == ConnectionState.Open) con.Close();
				con.Open();
				com = new SqlCommand();
				com.Connection = con;
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Error: " + ex.Message);
				txtUser.Focus();
			}
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

			Program.mlogin = txtUser.Text;
			Program.password = txtPass.Text;
			if (Program.ketnoi() == 0)
			{
				txtUser.ResetText();
				txtPass.ResetText();
				txtUser.Focus();

				return;
			}
			//kiểm tra user
			//String strlenh = "SELECT loginname from sys.syslogins where sid= suser_sID('" + program.mlogin + "')";
			String strlenh = "SELECT name from sys.sysusers where sid= suser_sID('" + Program.mlogin + "')";
			Program.myReader = Program.ExecSqlDataReader(strlenh, Program.connstr);
			Program.myReader.Read();
			Program.username = Program.myReader.GetString(0);//lay username
			if (Convert.IsDBNull(Program.username))
			{
				MessageBox.Show("error3", "", MessageBoxButtons.OK);
				txtUser.Focus();
				return;
			}
			Program.myReader.Close();
			strlenh = "sp_helpuser '" + Program.username + "'";// trả về các field username groupname loginname dbname userID sid
			try
			{
				Program.myReader = Program.ExecSqlDataReader(strlenh, Program.connstr);
			}
			catch (InvalidOperationException)
			{
				MessageBox.Show("error2", "", MessageBoxButtons.OK);
				return;
			}
			//lấy groupname 
			if (Program.myReader.Read())
			{
				Program.mgroup = Program.myReader.GetString(1);
				nhom = Program.mgroup;
			}
			else
			{
				MessageBox.Show("error1", "", MessageBoxButtons.OK);
				return;
			}
			Program.myReader.Close();
			//lấy ten của user. kiểm tra có chủ tài khoản là ai
			if (nhom == "staff")
			{

				strlenh = "select TenNV from NhanVien where MaNV ='" + Program.username + "'";

			}
			if (nhom == "director")
			{
				strlenh = "select HoTen from GiamDoc where MaGD ='" + Program.username + "'";
			}
			if (nhom == "manager")
			{
				strlenh = "select HoTenQL from QuanLy where MaQL ='" + Program.username + "'";
			}
			Program.myReader = Program.ExecSqlDataReader(strlenh, Program.connstr);
			if (Program.myReader.HasRows)
			{
				Program.myReader.Read();
				Program.mten = Program.myReader.GetString(0);
				ten = Program.mten;
			}
			else
			{
				MessageBox.Show("Error Không có thông tin người này", " ", MessageBoxButtons.OK);
				Program.myReader.Close();
				Program.conn.Close();
				return;
			}


			Program.myReader.Close();
			strlenh = "select TrangThai from CapNhatTaiKhoan where TenLogin ='" + Program.username + "'";
			Program.myReader = Program.ExecSqlDataReader(strlenh, Program.connstr);
			if (Program.myReader.Read())
			{

				kt = Program.myReader.GetString(0);
			}
			if (kt == "0")
			{
				string err = "";
				bool f = dbkttk.CapNhatTK(ref err, Program.username, "1");
				Program.conn.Close();
				this.Close();
			}
			if (kt == "1")
			{
				MessageBox.Show("Tai Khoan Da Dang Nhap", " ", MessageBoxButtons.OK);
				Program.myReader.Close();
				Program.conn.Close();
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
	}
}
