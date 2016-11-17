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
using BALayer;

namespace QuanLyCuaHangBanDia
{
	public partial class formLapHoaDon : Form
	{
		string strConnectionString = "Data Source=.;Initial Catalog=QLCuaHangDia;Integrated Security=True";
		SqlConnection conn = null;

		SqlDataAdapter daKhachHang = null;

		DataTable dtKhachHang = null;
		DataView dtvKhachHang = null;

		SqlDataAdapter dahoadon = null;

		DataTable dthoadon = null;
		DataView dtvhoadon = null;

		SqlDataAdapter dacthd = null;

		DataTable dtcthd = null;
		DataView dtvcthd = null;

		SqlDataAdapter dadia = null;

		DataTable dtdia = null;

		DBHoaDon dbhd;
		DBCTHoaDon dbcthd;
		SqlDataAdapter daHoaDon = null;

		DataTable dtHoaDon = null;

		SqlDataAdapter daDia = null;

		DataTable dtDia = null;

		float a = 0;
		public formLapHoaDon()
		{
			InitializeComponent();
			dbhd = new DBHoaDon();
			dbcthd = new DBCTHoaDon();
		}
		private void FormLoad(object sender, EventArgs e)
		{

			btnTaomoi.Enabled = false;
			try
			{
				// Khởi động connection 
				conn = new SqlConnection(strConnectionString);
				if (conn.State == ConnectionState.Open)
					conn.Close();
				conn.Open();
				loaddata();
				daKhachHang = new SqlDataAdapter("SELECT MaKH,TenKH FROM KHACHHANG", conn);
				dtKhachHang = new DataTable();
				dtKhachHang.Clear();
				daKhachHang.Fill(dtKhachHang);
				// Đưa dữ liệu lên DataGridView  
				dtvKhachHang = new DataView(dtKhachHang);
			}
			catch (SqlException)
			{
				MessageBox.Show("Hệ thống không đọc được dữ liệu từ database!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		void loaddata()
		{
			daHoaDon = new SqlDataAdapter("SELECT MaHD FROM HoaDon", conn);
			dtHoaDon = new DataTable();
			dtHoaDon.Clear();
			daHoaDon.Fill(dtHoaDon);
			cbmahd.DataSource = dtHoaDon;
			cbmahd.DisplayMember = "MaHD";
			cbmahd.ValueMember = "MaHD";
	
			daDia = new SqlDataAdapter("SELECT MaD FROM Dia", conn);
			dtDia = new DataTable();
			dtDia.Clear();
			daDia.Fill(dtDia);
			cbmad.DataSource = dtDia;
			cbmad.DisplayMember = "MaD";
			cbmad.ValueMember = "MaD";

			daKhachHang = new SqlDataAdapter("SELECT MaKH FROM KhachHang", conn);
			dtKhachHang = new DataTable();
			dtKhachHang.Clear();
			daKhachHang.Fill(dtKhachHang);
			cbkh.DataSource = dtKhachHang;
			cbkh.DisplayMember = "MaKH";
			cbkh.ValueMember = "MaKH";

			panel1.Enabled = true;
			cbkh.ResetText();
			cbmad.ResetText();
			cbmahd.ResetText();
			panel2.Enabled = false;
			btnLuu1.Enabled = false;
			txtNgayLapHD.Enabled = true;
			button1.Enabled = false;
			btnxemchitiet.Enabled = false;
			btcapnhat.Enabled = false;
			button2.Enabled = false;
			dgvKHACHHANG.DataSource = "";
			dgvHoaDon.DataSource = "";
			dgvdia.DataSource = "";
			txtsoluong.ResetText();
		}
		private void btnktttkh_Click(object sender, EventArgs e)
		{

			dtvKhachHang.RowFilter = "MaKH='" + cbkh.SelectedValue.ToString() + "'";
			dgvKHACHHANG.DataSource = dtvKhachHang;
			btnLuu1.Enabled = true;
		}
		private void btnluu_Click(object sender, EventArgs e)
		{
			panel2.Enabled = true;
			button2.Enabled = true;
			button1.Enabled = true;
			btnxemchitiet.Enabled = true;
			btcapnhat.Enabled = true;
			panel1.Enabled = false;
			bool f = false;
			string err = "";
			try
			{
				f = dbhd.ThemHDon(ref err, cbmahd.Text, cbkh.SelectedValue.ToString(), DateTime.Parse(txtNgayLapHD.Text), a);
				if (f)
				{
					// Load lại dữ liệu trên DataGridView 
					// Thông báo 
					MessageBox.Show("Đã lưu xong!");
					this.button3.Enabled = true;
				}
				else
				{
					MessageBox.Show("Hệ thống lưu bị lỗi!\n\r" + "Lỗi:" + err);
				}
			}
			catch (SqlException)
			{
				MessageBox.Show("Hệ thống lỗi, lưu không thành công!");
			}

		}
		private void button3_Click(object sender, EventArgs e)
		{
			dahoadon = new SqlDataAdapter("SELECT * FROM HOADON", conn);
			dthoadon = new DataTable();
			dthoadon.Clear();
			dahoadon.Fill(dthoadon);
			// Đưa dữ liệu lên DataGridView  
			dtvhoadon = new DataView(dthoadon);
			dtvhoadon.RowFilter = "MaHD='" + cbmahd.Text + "'";
			dgvHoaDon.DataSource = dtvhoadon;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			bool f = false;
			string err = "";
			try
			{
				f = dbcthd.ThemCTHD(ref err, cbmahd.Text, cbmad.SelectedValue.ToString(), int.Parse(txtsoluong.Text), a);
				if (f)
				{
					// Load lại dữ liệu trên DataGridView 
					// Thông báo 
					MessageBox.Show("Đã lưu xong!");
				}
				else
				{
					MessageBox.Show("Hệ thống lưu bị lỗi!\n\r" + "Lỗi:" + err);
				}
			}
			catch (SqlException)
			{
				MessageBox.Show("Hệ thống lỗi, lưu không thành công!");
			}
			btnTaomoi.Enabled = true;
		}
		private void btnxemchitiet_Click(object sender, EventArgs e)
		{
			dadia = new SqlDataAdapter("SELECT * FROM Dia", conn);
			dtdia = new DataTable();
			dtdia.Clear();
			dadia.Fill(dtdia);

			(dgvdia.Columns["MaD1"] as
			DataGridViewComboBoxColumn).DataSource = dtdia;
			(dgvdia.Columns["MaD1"] as
			DataGridViewComboBoxColumn).DisplayMember =
			"TuaDia";
			(dgvdia.Columns["MaD1"] as
			DataGridViewComboBoxColumn).ValueMember =
			"MaD";
			dacthd = new SqlDataAdapter("SELECT * FROM ChiTietHD WHERE MaHD = '" + cbmahd.Text + "'", conn);
			dtcthd = new DataTable();
			dtcthd.Clear();
			dacthd.Fill(dtcthd);
			// Đưa dữ liệu lên DataGridView  
			dtvcthd = new DataView(dtcthd);
			dgvdia.DataSource = dtvcthd;
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
		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				// Khai báo biến traloi 
				DialogResult traloi;
				// Hiện hộp thoại hỏi đáp 
				traloi = MessageBox.Show("Chắc hủy mẫu tin này không?", "Trả lời",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				// Kiểm tra có nhắp chọn nút Ok không? 
				string err = "";
				if (traloi == DialogResult.Yes)
				{
					// Thực hiện câu lệnh SQL 
					bool f = dbhd.XoaHDon(ref err, cbmahd.Text);
					if (f)
					{
						// Cập nhật lại DataGridView 
						//LoadData();
						// Thông báo 
						MessageBox.Show("Đã hủy xong!");
					}
					else
					{
						MessageBox.Show("Hệ thống hủy bị lỗi!\n\r" + "Lỗi:" + err);
					}
				}
				else
				{
					// Thông báo 
					MessageBox.Show("Hệ thống lỗi, hủy không thành công!");
				}
			}
			catch (SqlException)
			{
				MessageBox.Show("Không hủy được. Lỗi rồi!!!");
			}
			// Đóng kết nối
			loaddata();
		}
		private void btcapnhat_Click(object sender, EventArgs e)
		{
			string err = "";
			try
			{
				bool f = dbcthd.CapNhatCTHD(ref err, cbmahd.Text, cbmad.SelectedValue.ToString(), int.Parse(txtsoluong.Text), a);
				if (f)
				{
					// Load lại dữ liệu trên DataGridView 
					// Thông báo 
					MessageBox.Show("Đã cập nhật xong!");
				}
				else
				{
					MessageBox.Show("Đã cập nhật chưa xong!\n\r" + "Lỗi:" + err);
				}
			}
			catch (SqlException)
			{
				MessageBox.Show("Không cập nhật được! Hệ thống lỗi!");
			}
		}
		private void btnTaomoi_Click(object sender, EventArgs e)
		{
			loaddata();
		}
		private void btnLuu1_Click(object sender, EventArgs e)
		{
			panel2.Enabled = true;
			button2.Enabled = true;
			button1.Enabled = true;
			btnxemchitiet.Enabled = true;
			btcapnhat.Enabled = true;
			panel1.Enabled = false;
			bool f = false;
			string err = "";
			try
			{
				f = dbhd.ThemHDon(ref err, cbmahd.Text, cbkh.SelectedValue.ToString(), DateTime.Parse(txtNgayLapHD.Text), a);
				if (f)
				{
					// Load lại dữ liệu trên DataGridView 
					// Thông báo 
					MessageBox.Show("Đã lưu xong!");
					button3.Enabled = true;
				}
				else
				{
					MessageBox.Show("Hệ thống lưu chưa xong!\n\r" + "Lỗi:" + err);
				}
			}
			catch (SqlException)
			{
				MessageBox.Show("Hệ thống lỗi, lưu không thành công!");
			}
		}
	}
}
