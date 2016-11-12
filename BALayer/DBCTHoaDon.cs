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
	public class DBCTHoaDon
	{
		DAL db = null;
		public DBCTHoaDon()
		{
			db = new DAL();
		}
		public DataSet LayCTHD()
		{
			return db.ExecuteQueryDataSet("select * from ChiTietHD", CommandType.Text, null);
		}
		public bool ThemCTHD(ref string err, string MaHD,string MaD,int SoLuong , float TongTien)
		{
			return db.MyExecuteNonQuery("SpThemChiTietHD",
				CommandType.StoredProcedure, ref err,
				new SqlParameter("@MaHD", MaHD),
				new SqlParameter("@MaD", MaD),
				new SqlParameter("@SoLuong", SoLuong),
				new SqlParameter("@TongTien", TongTien));

		}
		public bool XoaCTHD(ref string err, string MaHD, string MaD)
		{
			return db.MyExecuteNonQuery("SpXoaChiTietHD",
				CommandType.StoredProcedure, ref err, new SqlParameter("@MaHD", MaHD), new SqlParameter("@MaD", MaD));
		}
		public bool CapNhatCTHD(ref string err, string MaHD,string MaD,int SoLuong, float TongTien)
		{
			return db.MyExecuteNonQuery("SpCapNhatChiTietHD",
				CommandType.StoredProcedure, ref err,
				new SqlParameter("@MaHD", MaHD),
				new SqlParameter("@MaD", MaD),
				new SqlParameter("@SoLuong", SoLuong),
				new SqlParameter("@TongTien", TongTien));


		}
	}
}
