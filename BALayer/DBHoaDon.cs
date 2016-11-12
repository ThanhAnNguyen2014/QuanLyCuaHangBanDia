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
	public class DBHoaDon
	{
		DAL db = null;
		public DBHoaDon()
		{
			db = new DAL();
		}
		public DataSet LayHD()
		{
			return db.ExecuteQueryDataSet("select * from HoaDon", CommandType.Text, null);
		}
		public bool ThemHDon(ref string err, string MaHD,string MaKH,DateTime NgayLapHD, float TongTien)
		{
			return db.MyExecuteNonQuery("SpThemHoaDon",
				CommandType.StoredProcedure, ref err,
				new SqlParameter("@MaHD", MaHD),
				new SqlParameter("@MaKH", MaKH),
				new SqlParameter("@NgayLapHD", NgayLapHD),
				new SqlParameter("@TongTien", TongTien));

		}
		public bool XoaHDon(ref string err, string MaHD)
		{
			return db.MyExecuteNonQuery("SpXoaHoaDon",
				CommandType.StoredProcedure, ref err, new SqlParameter("@MaHD", MaHD));
		}
		public DataSet timhoadon(string MaHD)
		{
			return db.ExecuteQueryDataSet("timhoadon'" + MaHD + "'", CommandType.Text, null);
		}
	}
}
