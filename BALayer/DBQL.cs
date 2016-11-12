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
	public class DBQL
	{
		DAL db = null;
		public DBQL()
		{
			db = new DAL();
		}
		public DataSet LayQanLy()
		{
			return db.ExecuteQueryDataSet("select * from QuanLy", CommandType.Text, null);
		}
		public bool ThemQuanLy(ref string err, string MaQL, string HoTenQL, string Diachi, DateTime NgaySinh, string SDT)
		{
			return db.MyExecuteNonQuery("SpThemQuanLy",
				CommandType.StoredProcedure, ref err,
				new SqlParameter("@MaQL", MaQL),
				new SqlParameter("@HoTenQL", HoTenQL),
				new SqlParameter("@DiaChi", Diachi),
				new SqlParameter("@NgaySinh", NgaySinh),
				new SqlParameter("@SDT", SDT));
		}

		public bool XoaQuanLy(ref string err, string MaQL)
		{
			return db.MyExecuteNonQuery("SpXoaQuanLy",
				CommandType.StoredProcedure, ref err, new SqlParameter("@MaQL", MaQL));
		}
		public bool CapNhatQL(ref string err, string MaQL, string HoTenQL, string Diachi, DateTime NgaySinh, string SDT)
		{
			return db.MyExecuteNonQuery("SpCapNhatQuanLy",
				CommandType.StoredProcedure, ref err,
				new SqlParameter("@MaQL", MaQL),
				new SqlParameter("@HoTenQL", HoTenQL),
				new SqlParameter("@DiaChi", Diachi),
				new SqlParameter("@NgaySinh", NgaySinh),
				new SqlParameter("@SDT", SDT));
		}
	}
}
