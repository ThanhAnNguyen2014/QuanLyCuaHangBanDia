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
	public partial class formTimDia : Form
	{
		DBDia dbd = new DBDia();
		DataTable dtd = null;
		public formTimDia()
		{
			InitializeComponent();
			timdia_Load();
		}


		private void timdia_Load()
		{
			dtd = new DataTable();
			dtd.Clear();
			dtd = dbd.LayDia().Tables[0];
			// Đưa dữ liệu lên DataGridView  
			dgv.DataSource = dtd;
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

		private void chagne(object sender, EventArgs e)
		{
			dtd = new DataTable();
			dtd = dbd.timDia(txttim.Text).Tables[0];
			dgv.DataSource = dtd;
		}
	}

}
