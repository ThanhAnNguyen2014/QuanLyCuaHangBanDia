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
	public partial class formXemHoaDon : Form
	{
		string strConnectionString = "Data Source=192.168.1.2;Initial Catalog=QLCuaHangDia;User ID=sa;Password=123";

		SqlConnection conn = null;

		SqlDataAdapter dahoadon = null;

		DataTable dthoadon = null;
		DataView dtvhoadon = null;
		SqlDataAdapter daHoaDon = null;

		DataTable dtHoaDon = null;
		public formXemHoaDon()
		{
			InitializeComponent();
			XemHoaDon_Load();
		}
		private void XemHoaDon_Load()
		{
			try
			{
				// Khởi động connection 
				conn = new SqlConnection(strConnectionString);
				if (conn.State == ConnectionState.Open)
					conn.Close();
				conn.Open();

			}
			catch (SqlException)
			{
				MessageBox.Show("Hệ thống không truy cập được database", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			daHoaDon = new SqlDataAdapter("SELECT ma,ten FROM thang", conn);
			dtHoaDon = new DataTable();
			dtHoaDon.Clear();
			daHoaDon.Fill(dtHoaDon);
			xemloainao.DataSource = dtHoaDon;
			xemloainao.DisplayMember = "ten";
			xemloainao.ValueMember = "ma";
			xemloainao.Text = "All";
		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			dahoadon = new SqlDataAdapter("SELECT * FROM dbo.xemhdtrongthang('" + xemloainao.SelectedValue.ToString() + "')", conn);
			dthoadon = new DataTable();
			dthoadon.Clear();
			dahoadon.Fill(dthoadon);
			// Đưa dữ liệu lên DataGridView  
			dtvhoadon = new DataView(dthoadon);
			dgvhoadon.DataSource = dtvhoadon;
			//this.btnluu.Enabled = true; 
		}
		private void btnShowAll_Click(object sender, EventArgs e)
		{
			dahoadon = new SqlDataAdapter("SELECT * FROM xemhd", conn);
			dthoadon = new DataTable();
			dthoadon.Clear();
			dahoadon.Fill(dthoadon);
			// Đưa dữ liệu lên DataGridView  
			dtvhoadon = new DataView(dthoadon);
			dgvhoadon.DataSource = dtvhoadon;
			xemloainao.Text = "All";
		}
		private void bttinh_Click(object sender, EventArgs e)
		{

			if (xemloainao.Text != "All")
				dahoadon = new SqlDataAdapter("select distinct(dbo.tinhtongtientungthang('" + xemloainao.SelectedValue.ToString() + "')) from dbo.xemhdtrongthang('" + xemloainao.SelectedValue.ToString() + "')", conn);
			else
				dahoadon = new SqlDataAdapter("Select distinct(dbo.tinhtongdoanhthu()) from dbo.xemhd", conn);
			dthoadon = new DataTable();
			dthoadon.Clear();
			dahoadon.Fill(dthoadon);
			// Đưa dữ liệu lên DataGridView  
			dtvhoadon = new DataView(dthoadon);
			dgvtinh.DataSource = dtvhoadon;
		}
		private void btnTrove_Click(object sender, EventArgs e)
		{
			// Khai báo biến traloi 
			DialogResult traloi;
			// Hiện hộp thoại hỏi đáp 
			traloi = MessageBox.Show("Chắc không?", "Trả lời",
			MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			// Kiểm tra có nhắp chọn nút Ok không? 
			if (traloi == DialogResult.OK) this.Close();
		}
	}
}
