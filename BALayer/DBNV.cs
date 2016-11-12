using DBLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BALayer
{
	public class DBNV
	{
		DAL db = null;
		public DBNV()
		{
			db = new DAL();
		}
		public DataSet LayNVien()
		{
			return db.ExecuteQueryDataSet("select * from NhanVien", CommandType.Text, null);
		}
		public bool ThemNV(ref string err, string MaNV, string TenNV, DateTime NgaySinh, string Diachi, string SDT)
		{
			return db.MyExecuteNonQuery("SpThemNhanVien",
				CommandType.StoredProcedure, ref err,
				new SqlParameter("@MaNV", MaNV),
				new SqlParameter("@TenNV", TenNV),
				new SqlParameter("@NgaySinh", NgaySinh),
				new SqlParameter("@DiaChi", Diachi),
				new SqlParameter("@SDT", SDT));

		}
		public bool XoaNVien(ref string err, string MaNV)
		{
			return db.MyExecuteNonQuery("SpXoaNhanVien",
				CommandType.StoredProcedure, ref err, new SqlParameter("@MaNV", MaNV));
		}
		public bool CapNhatNV(ref string err, string MaNV, string TenNV, DateTime NgaySinh, string Diachi, string SDT)
		{
			return db.MyExecuteNonQuery("SpCapNhatNhanVien",
				CommandType.StoredProcedure, ref err,
				new SqlParameter("@MaNV", MaNV),
				new SqlParameter("@TenNV", TenNV),
				new SqlParameter("@NgaySinh", NgaySinh),
				new SqlParameter("@DiaChi", Diachi),
				new SqlParameter("@SDT", SDT));
		}
	}
}
