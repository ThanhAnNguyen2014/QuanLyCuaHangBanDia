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
	public partial class formChiTietHoaDon : Form
	{
		string strConnectionString = "Data Source=.;Initial Catalog=QLCuaHangDia;Integrated Security=True";

		SqlConnection conn = null;

		SqlDataAdapter dahoadon = null;

		DataTable dthoadon = null;
		DataView dtvhoadon = null;

		SqlDataAdapter dakhachhang = null;

		DataTable dtkhachhang = null;
		DataView dtvkhachhang = null;

		SqlDataAdapter dacthd = null;

		DataTable dtcthd = null;
		DataView dtvcthd = null;
		SqlDataAdapter daHoaDon = null;

		DataTable dtHoaDon = null;
		public formChiTietHoaDon()
		{
			InitializeComponent();
			XemChiTietHoaDon_Load();


		}
		private void XemChiTietHoaDon_Load()
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
				MessageBox.Show("Lỗi hệ thống, không nhận được dữ liệu", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			daHoaDon = new SqlDataAdapter("SELECT MaHD FROM HoaDon", conn);
			dtHoaDon = new DataTable();
			dtHoaDon.Clear();
			daHoaDon.Fill(dtHoaDon);
			xemloainao.DataSource = dtHoaDon;
			xemloainao.DisplayMember = "MaHD";
			xemloainao.ValueMember = "MaHD";
			xemloainao.Text = "All";
			//
			dakhachhang = new SqlDataAdapter("SELECT * FROM KHACHHANG", conn);
			// Vận chuyển dữ liệu vào DataTable dtHoaDon
			dtkhachhang = new DataTable();
			dtkhachhang.Clear();
			dakhachhang.Fill(dtkhachhang);
			// Đưa dữ liệu lên DataGridView  
			dtvkhachhang = new DataView(dtkhachhang);
			//
			dacthd = new SqlDataAdapter("SELECT * FROM ChiTietHD", conn);
			// Vận chuyển dữ liệu vào DataTable dtHoaDon
			dtcthd = new DataTable();
			dtcthd.Clear();
			dacthd.Fill(dtcthd);
			// Đưa dữ liệu lên DataGridView  
			dtvcthd = new DataView(dtcthd);
			//
			dahoadon = new SqlDataAdapter("SELECT * FROM HoaDon", conn);
			dthoadon = new DataTable();
			dthoadon.Clear();
			dahoadon.Fill(dthoadon);
			// Đưa dữ liệu lên DataGridView  
			dtvhoadon = new DataView(dthoadon);
		}

		private void btnOK_Click(object sender, EventArgs e)
		{

			dtvhoadon.RowFilter = "MaHD='" + xemloainao.SelectedValue.ToString() + "'";
			dgvhoadon.DataSource = dtvhoadon;
			dgvhoadon_CellClick(null, null);
		}
		private void btnShowAll_Click(object sender, EventArgs e)
		{
			dtvhoadon.RowFilter = "";
			dgvhoadon.DataSource = dtvhoadon;
			xemloainao.Text = "All";
		}
		private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = 0;
			if (dgvhoadon.CurrentCell.RowIndex >= 0)
				r = dgvhoadon.CurrentCell.RowIndex;
			string strMaKH = dgvhoadon.Rows[r].Cells[1].Value.ToString();
			dtvkhachhang.RowFilter = "MaKH='" + strMaKH + "'";
			dgvkhachhang.DataSource = dtvkhachhang;

			int s = 0;
			if (dgvhoadon.CurrentCell.RowIndex >= 0)
				s = dgvhoadon.CurrentCell.RowIndex;
			string strMaHD =
				dgvhoadon.Rows[s].Cells[0].Value.ToString();
			dtvcthd.RowFilter = "MaHD='" + strMaHD + "'";
			dgvcthd.DataSource = dtvcthd;
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
