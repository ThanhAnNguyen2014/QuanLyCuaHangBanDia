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
	public partial class formNhanVien : Form
	{
		public formNhanVien()
		{
			InitializeComponent();
			dbnv = new DBNV();
		}
		DBNV dbnv;

		bool Them;
		DataTable dtnhanvien = null;

		private void NhanVien_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		void LoadData()
		{
			try
			{
				// Vận chuyển dữ liệu vào DataTable dtKhachHang 
				dtnhanvien = new DataTable();
				dtnhanvien.Clear();
				dtnhanvien = dbnv.LayNVien().Tables[0];
				// Đưa dữ liệu lên DataGridView  
				dgvKHACHHANG.DataSource = dtnhanvien;
				// Xóa trống các đối tượng trong Panel 
				txtMaNV.ResetText();
				txtTen.ResetText();
				txtDiaChi.ResetText();
				txtDienthoai.ResetText();
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
				MessageBox.Show("Hệ thống không lấy được nội dung trong trong database...", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			// Kich hoạt biến Them 
			Them = true;
			// Xóa trống các đối tượng trong Panel 
			txtMaNV.ResetText();
			txtTen.ResetText();
			txtDiaChi.ResetText();
			txtDienthoai.ResetText();
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
			txtMaNV.Focus();
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
			this.txtMaNV.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			bool f = false;
			if (Them)
			{
				string err = "";
				try
				{
					f = dbnv.ThemNV(ref err, txtMaNV.Text, txtTen.Text, DateTime.Parse(txtNgaySinh.Text), txtDiaChi.Text, txtDienthoai.Text);
					if (f)
					{
						// Load lại dữ liệu trên DataGridView 
						LoadData();
						// Thông báo 
						//MessageBox.Show("Đã thêm xong!");
					}
					else
					{
						MessageBox.Show("Quá trình thêm bị lỗi!\n\r\n Vui lòng nhập mã NV là số 100 =< x < =105" + " Lỗi:\n" + err);
					}
				}
				catch (SqlException)
				{
					MessageBox.Show("Quá trình thêm bị lỗi!");
				}
			}
			if (!Them)
			{
				string err = "";
				try
				{
					f = dbnv.CapNhatNV(ref err, txtMaNV.Text, txtTen.Text, DateTime.Parse(txtNgaySinh.Text), txtDiaChi.Text, txtDienthoai.Text);
					if (f)
					{
						// Load lại dữ liệu trên DataGridView 
						LoadData();
						// Thông báo 
						//MessageBox.Show("Đã cap nhat xong!");
					}
					else
					{
						MessageBox.Show("Hệ thống cập nhật lỗi!\n\r" + "Lỗi:" + err);
					}
				}
				catch (SqlException)
				{
					MessageBox.Show("Hệ thống không cập nhật được!. Lỗi");
				}
			}
		}

		private void btnHuy_Click(object sender, EventArgs e)
		{
			// Xóa trống các đối tượng trong Panel 
			txtMaNV.ResetText();
			txtTen.ResetText();
			txtDiaChi.ResetText();
			txtDienthoai.ResetText();
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
				string strMAKH =dgvKHACHHANG.Rows[r].Cells[0].Value.ToString();
				// Viết câu lệnh SQL 
				// Hiện thông báo xác nhận việc xóa mẫu tin 
				// Khai báo biến traloi 
				DialogResult result;
				// Hiện hộp thoại hỏi đáp 
				result = MessageBox.Show("Bạn có chắc muốn xóa thông tin Nhân Viên này không?", "Trả lời",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				// Kiểm tra có nhắp chọn nút Ok không? 
				string err = "";
				if (result == DialogResult.Yes)
				{

					// Thực hiện câu lệnh SQL 
					bool f = dbnv.XoaNVien(ref err, strMAKH);
					if (f)
					{
						// Cập nhật lại DataGridView 
						LoadData();
						// Thông báo 
						MessageBox.Show("Đã xóa xong!");
					}
					else
					{
						MessageBox.Show("Hệ Thống lỗi!\n\r" + "Lỗi:" + err);
					}
				}
				else
				{
					// Thông báo 
					MessageBox.Show("Xóa Nhân viên Lỗi!");
				}
			}
			catch (SqlException)
			{
				MessageBox.Show("Hệ Thống lỗi, Vui lòng xóa lại!!!");
			}
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

		private void btnReLoad_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void dgvKHACHHANG_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = dgvKHACHHANG.CurrentCell.RowIndex;
			// Chuyển thông tin lên panel nhập liệu
			txtMaNV.Text =dgvKHACHHANG.Rows[r].Cells[0].Value.ToString();
			txtTen.Text =dgvKHACHHANG.Rows[r].Cells[1].Value.ToString();
			txtDiaChi.Text =dgvKHACHHANG.Rows[r].Cells[3].Value.ToString();
			txtDienthoai.Text =dgvKHACHHANG.Rows[r].Cells[4].Value.ToString();
			txtNgaySinh.Text =dgvKHACHHANG.Rows[r].Cells[2].Value.ToString();
		}

	}
}
