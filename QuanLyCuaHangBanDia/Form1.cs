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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		void frmNhanvien()
		{
			Form frm = new formNhanVien();
			frm.ShowDialog();
		}
		void frmNhapDia()
		{
			Form frm = new formNhapDia();
			frm.ShowDialog();
		}
		void frmKhachhang()
		{
			Form frm = new formKhachHang();
			frm.ShowDialog();
		}
		void frmQuanLy()
		{
			Form frm = new QuanLy();
			frm.ShowDialog();
		}
		void frmLapHD()
		{
			Form frm = new formLapHoaDon();
			frm.ShowDialog();
		}
		void frmHoaDonTheoThang()
		{
			Form frm = new formXemHoaDon();
			frm.ShowDialog();
		}
		void frmDiaBanTheoThang()
		{
			Form frm = new formDia();
			frm.ShowDialog();
		}
		private void quanLiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmQuanLy();
		}

		private void nhanVienBanHangToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmNhanvien();
		}

		private void nhapDiaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmNhapDia();
		}

		private void thongTinKhachHang_Click(object sender, EventArgs e)
		{
			frmKhachhang();
		}

		private void lapHD_Click(object sender, EventArgs e)
		{
			frmLapHD();
		}

		private void thốngKêHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmHoaDonTheoThang();
		}

		private void thốngKêĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmDiaBanTheoThang();
		}
		void frmChiTietHoaDon()
		{
			Form frm = new formChiTietHoaDon();
			frm.ShowDialog();
		}
		private void danhMụcHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			frmChiTietHoaDon();
		}
		void frmTimDia()
		{
			Form frm = new formTimDia();
			frm.ShowDialog();
		}
		private void tìmĐĩaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmTimDia();
		}
		void frmTimHoaDon()
		{
			Form frm = new formTimHoaDon();
			frm.ShowDialog();
		}
		private void tìmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmTimHoaDon();
		}
		void frmFulltextSearch()
		{
			Form frm = new formFulltextSearch();
			frm.ShowDialog();
		}
		private void tToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmFulltextSearch();
		}
	}
}
