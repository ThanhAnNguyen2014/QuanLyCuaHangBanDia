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
	public partial class formDia : Form
	{
		string strConnectionString = "Data Source=192.168.1.2;Initial Catalog=QLCuaHangDia;User ID=sa;Password=123";

		SqlConnection conn = null;

		SqlDataAdapter dahoadon = null;

		DataTable dthoadon = null;
		DataView dtvhoadon = null;

		SqlDataAdapter dadia = null;

		DataTable dtdia = null;
		DataView dtvdia = null;

		SqlDataAdapter daHoaDon = null;

		DataTable dtHoaDon = null;
		public formDia()
		{
			InitializeComponent();
			XemDia_Load();
		}
		private void XemDia_Load()
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
				MessageBox.Show("Hệ thống không truy cập được CSDL!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			daHoaDon = new SqlDataAdapter("SELECT ma,ten FROM thang", conn);
			dtHoaDon = new DataTable();
			dtHoaDon.Clear();
			daHoaDon.Fill(dtHoaDon);
			xemloainao.DataSource = dtHoaDon;
			xemloainao.DisplayMember = "ten";
			xemloainao.ValueMember = "ma";
			xemloainao.Text = "All";

			dadia = new SqlDataAdapter("select * from dbo.dsDia", conn);
			dtdia = new DataTable();
			dtdia.Clear();
			dadia.Fill(dtdia);
			// Đưa dữ liệu lên DataGridView  
			dtvdia = new DataView(dtdia);
		}
		private void btnOK_Click(object sender, EventArgs e)
		{
			dahoadon = new SqlDataAdapter("select * from dbo.diabanduoctrongthang('" + xemloainao.SelectedValue.ToString() + "')", conn);
			dthoadon = new DataTable();
			dthoadon.Clear();
			dahoadon.Fill(dthoadon);
			// Đưa dữ liệu lên DataGridView  
			dtvhoadon = new DataView(dthoadon);
			dgvhoadon.DataSource = dtvhoadon;
		}
		private void btnShowAll_Click(object sender, EventArgs e)
		{
			dahoadon = new SqlDataAdapter("select * from dbo.tongsodiabanduoc()", conn);
			dthoadon = new DataTable();
			dthoadon.Clear();
			dahoadon.Fill(dthoadon);
			// Đưa dữ liệu lên DataGridView  
			dtvhoadon = new DataView(dthoadon);
			dgvhoadon.DataSource = dtvhoadon;
			xemloainao.Text = "All";
		}
		private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = 0;
			if (dgvhoadon.CurrentCell.RowIndex >= 0)
				r = dgvhoadon.CurrentCell.RowIndex;
			string strMaKH =
				dgvhoadon.Rows[r].Cells[0].Value.ToString();
			dtvdia.RowFilter = "MaD='" + strMaKH + "'";
			dgvdia.DataSource = dtvdia;
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
