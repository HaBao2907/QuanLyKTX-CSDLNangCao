using KTX.Interface;
using KTX.Model;
using KTX.Procedure;
using LibNetCore.Data;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace KTX.Service
{
    public class HeThongService : IHeThongService
    {
        #region Hệ thống

        private IDbHelper _dbHelper;
        public HeThongService(IDbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }

        public async Task<IEnumerable<NguoiDung>> HeThong_DangNhapHeThong(string userName, string matKhau)
        {
            var paramater =  new OracleDynamicParameters();
            paramater.Add("p_nsd", OracleDbType.Varchar2, ParameterDirection.Input, userName);
            paramater.Add("p_mk", OracleDbType.Varchar2, ParameterDirection.Input, matKhau);
            paramater.Add("cs", OracleDbType.RefCursor, ParameterDirection.Output);

            return await _dbHelper.ExecuteProcedureAsyn<NguoiDung>(storeProcedure: HeThongStore.HETHONG_DANGNHAP, paramater);
        }
         


        #endregion
    }
}
