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
	public partial class QuanLy : Form
	{
		public QuanLy()
		{
			InitializeComponent();
			dbql = new DBQL();
		}
		DBQL dbql;

		bool Them;
		DataTable dtquanly = null;

		private void dvgQuanLi_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		void LoadData()
		{
			try
			{
				// Vận chuyển dữ liệu vào DataTable dtKhachHang 
				dtquanly = new DataTable();
				dtquanly.Clear();
				dtquanly = dbql.LayQanLy().Tables[0];
				// Đưa dữ liệu lên DataGridView  
				dgvKHACHHANG.DataSource = dtquanly;
				// Xóa trống các đối tượng trong Panel 
				txtMaQL.ResetText();
				txtHoTenQL.ResetText();
				txtDiaChi.ResetText();
				txtsdt.ResetText();
				txtNgaySinh.ResetText();
				// Không cho thao tác trên các nút Lưu / Hủy 
				btnLuu.Enabled = false;
				btnHuy.Enabled = false;
				panel.Enabled = false;
				// Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
				btnThem.Enabled = true;
				btnSua.Enabled = true;
				btnXoa.Enabled = true;
				btnThoat.Enabled = true;
			}
			catch (SqlException)
			{
				MessageBox.Show("Hệ thống không lấy được dữ liệu trong database", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			// Kich hoạt biến Them 
			Them = true;
			// Xóa trống các đối tượng trong Panel 
			txtMaQL.ResetText();
			txtHoTenQL.ResetText();
			txtDiaChi.ResetText();
			txtsdt.ResetText();
			txtNgaySinh.ResetText();
			// Cho thao tác trên các nút Lưu / Hủy / Panel 
			btnLuu.Enabled = true;
			btnHuy.Enabled = true;
			panel.Enabled = true;
			// Không cho thao tác trên các nút Thêm / Xóa / Thoát 
			btnThem.Enabled = false;
			btnSua.Enabled = false;
			btnXoa.Enabled = false;
			btnThoat.Enabled = false;
			// Đưa con trỏ đến TextField txtMaKH 
			txtMaQL.Focus();
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			// Kích hoạt biến Sửa 
			Them = false;
			// Cho phép thao tác trên Panel 
			panel.Enabled = true;
			dgvKHACHHANG_CellClick(null, null);
			// Cho thao tác trên các nút Lưu / Hủy / Panel / Lây hình
			btnLuu.Enabled = true;
			btnHuy.Enabled = true;
			panel.Enabled = true;
			// Không cho thao tác trên các nút Thêm / Xóa / Thoát 
			btnThem.Enabled = false;
			btnSua.Enabled = false;
			btnXoa.Enabled = false;
			btnThoat.Enabled = false;
			// Đưa con trỏ đến TextField txtMaKH            
			txtMaQL.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			bool f = false;
			if (Them)
			{
				string err = "";
				try
				{
					f = dbql.ThemQuanLy(ref err, txtMaQL.Text, txtHoTenQL.Text, txtDiaChi.Text, DateTime.Parse(txtNgaySinh.Text), txtsdt.Text);
					if (f)
					{
						// Load lại dữ liệu trên DataGridView 
						LoadData();
						// Thông báo 
						//MessageBox.Show("Đã thêm xong!");
					}
					else
					{
						MessageBox.Show("Quá trình Thêm bị lỗi! Mã Quản lý 10=< x <= 14\n\r" + "Lỗi:" + err);
					}
				}
				catch (SqlException)
				{
					MessageBox.Show("Không thêm được. Lỗi rồi!");
				}
			}
			if (!Them)
			{
				string err = "";
				try
				{
					f = dbql.CapNhatQL(ref err, txtMaQL.Text, txtHoTenQL.Text, txtDiaChi.Text, DateTime.Parse(txtNgaySinh.Text), txtsdt.Text);
					if (f)
					{
						// Load lại dữ liệu trên DataGridView 
						LoadData();
						// Thông báo 
						MessageBox.Show("Đã cập nhật xong!");
					}
					else
					{
						MessageBox.Show("Cập nhật chưa xong!\n\r" + "Lỗi:" + err);
					}
				}
				catch (SqlException)
				{
					MessageBox.Show("Không cập nhật được. Lỗi rồi!");
				}
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			// Xóa trống các đối tượng trong Panel 
			txtMaQL.ResetText();
			txtHoTenQL.ResetText();
			txtDiaChi.ResetText();
			txtsdt.ResetText();
			txtNgaySinh.ResetText();
			// Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
			btnThem.Enabled = true;
			btnSua.Enabled = true;
			btnXoa.Enabled = true;
			btnThoat.Enabled = true;

			// Không cho thao tác trên các nút Lưu / Hủy / Panel 
			btnLuu.Enabled = false;
			btnHuy.Enabled = false;
			panel.Enabled = false;
			dgvKHACHHANG_CellClick(null, null);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				// Lấy thứ tự record hiện hành 
				int r = dgvKHACHHANG.CurrentCell.RowIndex;
				// Lấy MaKH của record hiện hành 
				string strMAKH =
				dgvKHACHHANG.Rows[r].Cells[0].Value.ToString();
				// Viết câu lệnh SQL 
				// Hiện thông báo xác nhận việc xóa mẫu tin 
				// Khai báo biến traloi 
				DialogResult result;
				// Hiện hộp thoại hỏi đáp 
				result = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				// Kiểm tra có nhắp chọn nút Ok không? 
				string err = "";
				if (result == DialogResult.Yes)
				{

					// Thực hiện câu lệnh SQL 
					bool f = dbql.XoaQuanLy(ref err, strMAKH);
					if (f)
					{
						// Cập nhật lại DataGridView 
						LoadData();
						// Thông báo 
						MessageBox.Show("Đã xóa xong!");
					}
					else
					{
						MessageBox.Show("Không xóa được!\n\r" + "Lỗi:" + err);
					}
				}
				else
				{
					// Thông báo 
					MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
				}
			}
			catch (SqlException)
			{
				MessageBox.Show("Không xóa được. Lỗi!!!");
			}
			// Đóng kết nối 
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			// Khai báo biến traloi 
			DialogResult result;
			// Hiện hộp thoại hỏi đáp 
			result = MessageBox.Show("Chắc không?", "Trả lời",
			MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			// Kiểm tra có nhắp chọn nút Ok không? 
			if (result == DialogResult.OK) this.Close();
		}

		private void dgvKHACHHANG_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// Thứ tự dòng hiện hành 
			int r = dgvKHACHHANG.CurrentCell.RowIndex;
			// Chuyển thông tin lên panel 
			txtMaQL.Text =
			dgvKHACHHANG.Rows[r].Cells[0].Value.ToString();
			txtHoTenQL.Text =
			dgvKHACHHANG.Rows[r].Cells[1].Value.ToString();
			txtDiaChi.Text =
			dgvKHACHHANG.Rows[r].Cells[2].Value.ToString();
			txtsdt.Text =
			dgvKHACHHANG.Rows[r].Cells[4].Value.ToString();
			txtNgaySinh.Text =
			dgvKHACHHANG.Rows[r].Cells[3].Value.ToString();

		}
		private void btnReLoad_Click(object sender, EventArgs e)
		{
			LoadData();
		}
	}
}
