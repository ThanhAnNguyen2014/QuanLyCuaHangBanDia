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
	public class DBKH
	{
		DAL db = null;
		public DBKH()
		{
			db = new DAL();
		}
		public DataSet LayKH()
		{
			return db.ExecuteQueryDataSet("select * from KhachHang", CommandType.Text, null);
		}
		public bool ThemKHang(ref string err, string MaKH, string TenKH, string Diachi, string SDT)
		{
			return db.MyExecuteNonQuery("SpThemKhachHang",
				CommandType.StoredProcedure, ref err,
				new SqlParameter("@MaKH", MaKH),
				new SqlParameter("@TenKH", TenKH),
				new SqlParameter("@Diachi", Diachi),
				new SqlParameter("@SDT", SDT));
		}
		public bool XoaKHang(ref string err, string MaKH)
		{
			return db.MyExecuteNonQuery("SpXoaKhachHang",
				CommandType.StoredProcedure, ref err, new SqlParameter("@MaKH", MaKH));
		}
		public bool CapNhatKHang(ref string err, string MaKH, string TenKH, string Diachi, string SDT)
		{
			return db.MyExecuteNonQuery("SpCapNhatKhachHang",
				CommandType.StoredProcedure, ref err,
				new SqlParameter("@MaKH", MaKH),
				new SqlParameter("@TenKH", TenKH),
				new SqlParameter("@Diachi", Diachi),
				new SqlParameter("@SDT", SDT));


		}
	}
}
