using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data;
using System.Data.SqlClient;

namespace BALayer
{
    public class DBDia
    {
		DAL db = null;
		public DBDia()
		{
			db = new DAL();

		}
		public DataSet LayDia()
		{
			return db.ExecuteQueryDataSet("select * from Dia", CommandType.Text, null);
		}
		public bool ThemDia(ref string err, string MaD, string TuaDia, string NSX, int SoLuong, Int32 DonGia, float KhuyenMai)
		{
			return db.MyExecuteNonQuery("SpThemDia",
				CommandType.StoredProcedure, ref err, 
				new SqlParameter("@MaD", MaD),
				new SqlParameter("@TuaDia", TuaDia),
				new SqlParameter("@NSX", NSX),
				new SqlParameter("@SoLuong", SoLuong),
				new SqlParameter("@DonGia", DonGia),
				new SqlParameter("@KhuyenMai", KhuyenMai)
			);
		}
		public bool XoaD(ref string err, string MaD)
		{
			return db.MyExecuteNonQuery("SpXoaDia",
				CommandType.StoredProcedure, ref err, new SqlParameter("@MaD", MaD));
		}
		public bool CapNhatD(ref string err, string MaD, string TuaDia,
		string NSX, int SoLuong, Int32 DonGia, float KhuyenMai)
		{
			return db.MyExecuteNonQuery("SpCapNhatDia",
				CommandType.StoredProcedure, ref err,
				new SqlParameter("@MaD", MaD),
				new SqlParameter("@TuaDia", TuaDia),
				new SqlParameter("@NSX", NSX),
				new SqlParameter("@SoLuong", SoLuong),
				new SqlParameter("@DonGia", DonGia),
				new SqlParameter("@KhuyenMai", KhuyenMai)
				);
		}
		public DataSet timDia(string TuaDia)
		{
			return db.ExecuteQueryDataSet("timdia'" + TuaDia + "'", CommandType.Text, null);
		}
	}
}
