using BALayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangBanDia
{
	public partial class formTimHoaDon : Form
	{
		DBHoaDon dbhd = new DBHoaDon();
		DataTable dthd = null;
		public formTimHoaDon()
		{
			InitializeComponent();
			timhoadon_Load();
		}

		private void txttim_TextChanged(object sender, EventArgs e)
		{
			dthd = new DataTable();
			dthd = dbhd.timhoadon(txttim.Text).Tables[0];
			dgv.DataSource = dthd;
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
		private void timhoadon_Load()
		{
			dthd = new DataTable();
			dthd.Clear();
			dthd = dbhd.LayHD().Tables[0];
			// Đưa dữ liệu lên DataGridView  
			dgv.DataSource = dthd;
		}
	}
}
