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
	public partial class formNhapDia : Form
	{
		public formNhapDia()
		{
			InitializeComponent();
			dbs = new DBDia();
			LoadData();
		}
		DBDia dbs;
		bool Them;
		DataTable dtdia = null;
		private void Nhapdia_Load(object sender, EventArgs e)
		{
			LoadData();
		}
		void LoadData()
		{
			try
			{
				// Vận chuyển dữ liệu vào DataTable dtKhachHang 
				dtdia = new DataTable();
				dtdia.Clear();
				dtdia = dbs.LayDia().Tables[0];
				// Đưa dữ liệu lên DataGridView  
				dgvKHACHHANG.DataSource = dtdia;

				// Xóa trống các đối tượng trong Panel 
				txtMadia.ResetText();
				txtTendia.ResetText();
				txtNSX.ResetText();
				txtSoluong.ResetText();
				txtDongia.ResetText();
				txtKhuyenMai.ResetText();
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
			txtMadia.ResetText();
			txtTendia.ResetText();
			txtNSX.ResetText();
			txtSoluong.ResetText();
			txtDongia.ResetText();
			txtKhuyenMai.ResetText();
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
			txtMadia.Focus();
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
			txtMadia.Focus();
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			bool f = false;
			if (Them)
			{
				string err = "";
				try
				{
					f = dbs.ThemDia(ref err, txtMadia.Text, txtTendia.Text, txtNSX.Text, Int32.Parse(txtSoluong.Text), Int32.Parse(txtDongia.Text), float.Parse(txtKhuyenMai.Text));
					if (f)
					{
						// Load lại dữ liệu trên DataGridView 
						LoadData();
						// Thông báo 
						//MessageBox.Show("Đã thêm xong!");
					}
					else
					{
						MessageBox.Show("Quá trình thêm bị lỗi!\n\rĐơn Giá >0\n Khuyến Mãi 0 < x < 100\n Mã Đĩa có dạng MD01\n Số lượng lớn hơn 0","Lỗi:" + err);
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
					f = dbs.CapNhatD(ref err, txtMadia.Text, txtTendia.Text, txtNSX.Text, int.Parse(txtSoluong.Text), Int32.Parse(txtDongia.Text), float.Parse(txtKhuyenMai.Text));
					if (f)
					{
						// Load lại dữ liệu trên DataGridView 
						LoadData();
						// Thông báo 
						MessageBox.Show("Đã cap nhat xong!");
					}
					else
					{
						MessageBox.Show("Hệ thống cập nhật lỗi!\n\rr" + "Lỗi:" + err);
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
			txtMadia.ResetText();
			txtTendia.ResetText();
			txtNSX.ResetText();
			txtSoluong.ResetText();
			txtDongia.ResetText();
			txtKhuyenMai.ResetText();
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
				DialogResult traloi;
				// Hiện hộp thoại hỏi đáp 
				traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				// Kiểm tra có nhắp chọn nút Ok không? 
				string err = "";
				if (traloi == DialogResult.Yes)
				{

					// Thực hiện câu lệnh SQL 
					bool f = dbs.XoaD(ref err, strMAKH);
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
					MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
				}
			}
			catch (SqlException)
			{
				MessageBox.Show("Xóa Sản Phẩm Đĩa lỗi!");
			}
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			// Khai báo biến traloi 
			DialogResult traloi;
			// Hiện hộp thoại hỏi đáp 
			traloi = MessageBox.Show("Chắc không?", "Trả lời",
			MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			// Kiểm tra có nhắp chọn nút Ok không? 
			if (traloi == DialogResult.OK) Close();
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void dgvKHACHHANG_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int r = dgvKHACHHANG.CurrentCell.RowIndex;
			// Chuyển thông tin lên panel 
			txtMadia.Text =
			dgvKHACHHANG.Rows[r].Cells[0].Value.ToString();
			txtTendia.Text =
			dgvKHACHHANG.Rows[r].Cells[1].Value.ToString();
			txtNSX.Text =
			dgvKHACHHANG.Rows[r].Cells[2].Value.ToString();
			txtSoluong.Text =
			dgvKHACHHANG.Rows[r].Cells[3].Value.ToString();
			txtDongia.Text =
			dgvKHACHHANG.Rows[r].Cells[4].Value.ToString();
			txtKhuyenMai.Text =
			dgvKHACHHANG.Rows[r].Cells[5].Value.ToString();
		}
	}
}
