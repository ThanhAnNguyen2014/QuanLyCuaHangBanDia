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
	public class DBKTTaiKhoan
	{
		DAL db = null;
		public DBKTTaiKhoan()
		{
			db = new DAL();
		}
		public bool CapNhatTK(ref string err, string TenTK, string TrangThai)
		{
			return db.MyExecuteNonQuery("SpCapNhatTaiKhoan",
				CommandType.StoredProcedure, ref err,
				new SqlParameter("@TenLogin", TenTK),
				new SqlParameter("@TrangThai", TrangThai));


		}
	}
}
