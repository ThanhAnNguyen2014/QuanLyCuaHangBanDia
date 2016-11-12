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
	public partial class formKhachHang : Form
	{
		public formKhachHang()
		{
			InitializeComponent();
			dbkh = new DBKH();
			LoadData();
		}
		DBKH dbkh;
		bool Them;
		DataTable dtkhachhang = null;
		void LoadData()
		{
			try
			{
				// Khởi động connection
				dtkhachhang = new DataTable();
				dtkhachhang.Clear();
				dtkhachhang = dbkh.LayKH().Tables[0];
				// Đưa dữ liệu lên DataGridView  
				dgvKHACHHANG.DataSource = dtkhachhang;
				txtMaKH.ResetText();
				txtTenKH.ResetText();
				txtDiaChi.ResetText();
				txtSoDT.ResetText();
				// Không cho thao tác trên các nút Lưu / Hủy
				btnOK.Enabled = false;
				btnCancel.Enabled = false;
				// panel.Enabled = false;
				// Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
				btnThem.Enabled = true;
				btnSua.Enabled = true;
				btnXoa.Enabled = true;
				btnTrove.Enabled = true;
			}
			catch (SqlException)
			{
				MessageBox.Show("Hệ thống không lấy được nội dung trong trong database...", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Khachhang_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void btnReload_Click(object sender, EventArgs e)
		{
			LoadData();
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
					bool f = dbkh.XoaKHang(ref err, strMAKH);
					if (f)
					{
						// Cập nhật lại DataGridView 
						LoadData();
						// Thông báo 
						//MessageBox.Show("Đã xóa xong!");
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
				MessageBox.Show("Không xóa được. Lỗi rồi!!!");
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			// Kich hoạt biến Them
			Them = true;
			// Xóa trống các đối tượng trong Panel
			txtMaKH.ResetText();
			txtTenKH.ResetText();
			txtDiaChi.ResetText();
			txtSoDT.ResetText();
			// Cho thao tác trên các nút Lưu / Hủy / Panel
			btnOK.Enabled = true;
			btnCancel.Enabled = true;
			panel.Enabled = true;
			// panel.Enabled = true;
			// Không cho thao tác trên các nút Thêm / Xóa / Thoát
			btnThem.Enabled = false;
			btnSua.Enabled = false;
			btnXoa.Enabled = false;
			btnTrove.Enabled = false;

			// Đưa con trỏ đến TextField txtMaKH
			txtMaKH.Focus();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			bool f = false;
			if (Them)
			{
				string err = "";
				try
				{
					f = dbkh.ThemKHang(ref err, txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSoDT.Text);
					if (f)
					{
						// Load lại dữ liệu trên DataGridView 
						LoadData();
						// Thông báo 
						//MessageBox.Show("Đã thêm xong!");
					}
					else
					{
						MessageBox.Show("Hệ thống Thêm bị lỗi!\n\r Vui lòng Nhập Ma KH có dạng KH01" + "\nLỗi:" + err);
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
					f = dbkh.CapNhatKHang(ref err, txtMaKH.Text, txtTenKH.Text, txtDiaChi.Text, txtSoDT.Text);
					if (f)
					{
						// Load lại dữ liệu trên DataGridView 
						LoadData();
						// Thông báo 
						MessageBox.Show("Đã cập nhật xong!");
					}
					else
					{
						MessageBox.Show("Hệ thống cập nhật lỗi!\n\r Vui lòng Nhập Ma KH có dạng KH01" + "Lỗi:" + err);
					}
				}
				catch (SqlException)
				{
					MessageBox.Show("Hệ thống không cập nhật được!. Lỗi");
				}
			}
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			// Kích hoạt biến Sửa 
			Them = false;
			// Cho phép thao tác trên Panel 
			panel.Enabled = true;
			dgvKHACHHANG_CellClick(null, null);
			// Cho thao tác trên các nút Lưu / Hủy / Panel / Lây hình
			btnOK.Enabled = true;
			btnCancel.Enabled = true;
			panel.Enabled = true;

			// Không cho thao tác trên các nút Thêm / Xóa / Thoát 
			btnThem.Enabled = false;
			btnSua.Enabled = false;
			btnXoa.Enabled = false;
			btnTrove.Enabled = false;
			// Đưa con trỏ đến TextField txtMaKH            
			txtMaKH.Focus();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Xóa trống các đối tượng trong Panel
			txtMaKH.ResetText();
			txtTenKH.ResetText();
			txtDiaChi.ResetText();
			txtSoDT.ResetText();
			// Cho thao tác trên các nút Lưu / Hủy / Panel
			btnOK.Enabled = false;
			btnCancel.Enabled = false;
			// panel.Enabled = true;
			// Không cho thao tác trên các nút Thêm / Xóa / Thoát
			btnThem.Enabled = true;
			btnSua.Enabled = true;
			btnXoa.Enabled = true;
			btnTrove.Enabled = true;

			dgvKHACHHANG_CellClick(null, null);
		}

		private void btnTrove_Click(object sender, EventArgs e)
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
			int r = dgvKHACHHANG.CurrentCell.RowIndex;
			// Chuyển thông tin lên panel 
			txtMaKH.Text =
			dgvKHACHHANG.Rows[r].Cells[0].Value.ToString();
			txtTenKH.Text =
			dgvKHACHHANG.Rows[r].Cells[1].Value.ToString();
			txtDiaChi.Text =
			dgvKHACHHANG.Rows[r].Cells[2].Value.ToString();
			txtSoDT.Text =
			dgvKHACHHANG.Rows[r].Cells[3].Value.ToString();

		}

	}
}
