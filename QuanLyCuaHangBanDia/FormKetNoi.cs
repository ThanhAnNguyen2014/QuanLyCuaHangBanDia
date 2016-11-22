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
	public partial class FormKetNoi : Form
	{
		public FormKetNoi()
		{
			InitializeComponent();
		}
		public string strConnectionString = "";
		public string diachiid = "";
		public string username = "";
		public string password = "";
		public string tencsdl = "";
		private void button5_Click(object sender, EventArgs e)
		{
			diachiid = txtid.Text;
			username = txtname.Text;
			password = txtpass.Text;
			tencsdl = txtcsdl.Text;
			strConnectionString = "Data Source=" + diachiid + ";Initial Catalog=" + tencsdl + ";Integrated Security=False;User ID=" + username + ";Password=" + password;

			if (diachiid.Equals("") || username.Equals("") || password.Equals("") || tencsdl.Equals(""))
			{
				MessageBox.Show("Thiếu thông tin! bạn cần điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				try
				{
					SqlConnection myConnection = new SqlConnection(strConnectionString);
					myConnection.Open();
					MessageBox.Show("Kết nối Thành Công!");
					Hide();
					Form formMain = new Form1();
					formMain.Show();

				}
				catch
				{
					MessageBox.Show("Kết Nối Không Thành Công!!!","Lỗi",MessageBoxButtons.OK, MessageBoxIcon.Error);
					Application.Exit();
				}			
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
