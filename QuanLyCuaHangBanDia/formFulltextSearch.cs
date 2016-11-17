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
	public partial class formFulltextSearch : Form
	{
		string strConnectionString = "Data Source=.;Initial Catalog=QLCuaHangDia;Integrated Security=True";

		SqlConnection conn = null;
		SqlCommand com;
		SqlDataAdapter daFullText = null;

		DataTable dtFullText = null;
		DataView dtvFullText = null;
		public formFulltextSearch()
		{
			InitializeComponent();
			FullTextSearch_Load();
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
		private void FullTextSearch_Load()
		{
			conn = new SqlConnection(strConnectionString);
			if (conn.State == ConnectionState.Open)
				conn.Close();
			conn.Open();
			com = new SqlCommand();
			com.Connection = conn;
			daFullText = new SqlDataAdapter("select * from Dia", conn);
			dtFullText = new DataTable();
			dtFullText.Clear();
			daFullText.Fill(dtFullText);
			// Đưa dữ liệu lên DataGridView  
			dtvFullText = new DataView(dtFullText);
			dgv.DataSource = dtvFullText;

		}
		private void btnTim_Click(object sender, EventArgs e)
		{
			daFullText = new SqlDataAdapter("select * from Dia where FREETEXT (*, '" + txttim.Text + "')", conn);
			dtFullText = new DataTable();
			dtFullText.Clear();
			daFullText.Fill(dtFullText);
			// Đưa dữ liệu lên DataGridView  
			dtvFullText = new DataView(dtFullText);
			dgv.DataSource = dtvFullText;
		}

	}
}
