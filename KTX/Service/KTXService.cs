using KTX.Interface;
using KTX.Model;
using KTX.Procedure;
using LibNetCore.Common;
using LibNetCore.Data;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace KTX.Service
{
    public class KTXService : IKTXService
    {
        IDbHelper _dbHelper;

        public KTXService(IDbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }


        public async Task<IEnumerable<DanhMucChung>> DanhMuc_BoPhan_LietKe()
        {
            var paramater = _dbHelper.GetOracleDefaultParam();

            paramater.Add("cs", OracleDbType.RefCursor, ParameterDirection.Output);
            return await _dbHelper.ExecuteProcedureAsyn<DanhMucChung>(HeThongStore.PDM_BOPHAN_LKE, paramater);
        }

        public async Task<int> DanhMuc_BoPhan_Nhap(DanhMucChung danhMuc)
        {

            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Int32, ParameterDirection.Input, danhMuc.ID);
            paramater.Add("p_ten", OracleDbType.NVarchar2, ParameterDirection.Input, danhMuc.TEN);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_BOPHAN_NHAP, paramater);
        }

        public async Task<int> DanhMuc_BoPhan_Xoa(string Id)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Varchar2, ParameterDirection.Input, Id);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_BOPHAN_XOA, paramater);

        }

        public async Task<IEnumerable<DanhMucChung>> DanhMuc_ChucVu_LietKe()
        {
            var paramater = _dbHelper.GetOracleDefaultParam();

            paramater.Add("cs", OracleDbType.RefCursor, ParameterDirection.Output);
            return await _dbHelper.ExecuteProcedureAsyn<DanhMucChung>(HeThongStore.PDM_CHUCVU_LKE, paramater);
        }

        public async Task<int> DanhMuc_ChucVu_Nhap(DanhMucChung danhMuc)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Decimal, ParameterDirection.Input, danhMuc.ID);
            paramater.Add("p_ten", OracleDbType.NVarchar2, ParameterDirection.Input, danhMuc.TEN);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_CHUCVU_NHAP, paramater);
        }

        public async Task<int> DanhMuc_ChucVu_Xoa(string Id)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Varchar2, ParameterDirection.Input, Id);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_CHUCVU_XOA, paramater);
        }


        public async Task<IEnumerable<DanhMucChung>> DanhMuc_Khu_LietKe()
        {
            var paramater = _dbHelper.GetOracleDefaultParam();

            paramater.Add("cs", OracleDbType.RefCursor, ParameterDirection.Output);
            return await _dbHelper.ExecuteProcedureAsyn<DanhMucChung>(HeThongStore.PDM_KHU_LKE, paramater);
        }

        public async Task<int> DanhMuc_Khu_Nhap(DanhMucChung danhMuc)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Decimal, ParameterDirection.Input, danhMuc.ID);
            paramater.Add("p_ten", OracleDbType.NVarchar2, ParameterDirection.Input, danhMuc.TEN);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_KHU_NHAP, paramater);
        }

        public async Task<int> DanhMuc_Khu_Xoa(string Id)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Varchar2, ParameterDirection.Input, Id);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_KHU_XOA, paramater);
        }

        public async Task<IEnumerable<LoaiPhong>> DanhMuc_DichVu_LietKe()
        {
            var paramater = _dbHelper.GetOracleDefaultParam();

            paramater.Add("cs", OracleDbType.RefCursor, ParameterDirection.Output);
            return await _dbHelper.ExecuteProcedureAsyn<LoaiPhong>(HeThongStore.PDM_DICHVU_LKE, paramater);
        }

        public async Task<int> DanhMuc_DichVu_Nhap(LoaiPhong danhMuc)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Int32, ParameterDirection.Input, danhMuc.ID);
            paramater.Add("p_ten", OracleDbType.NVarchar2, ParameterDirection.Input, danhMuc.TEN);
            paramater.Add("p_gia", OracleDbType.Decimal, ParameterDirection.Input, Utilities.FormatNumberToStringNumber(danhMuc.GIA));

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_DICHVU_NHAP, paramater);
        }

        public async Task<int> DanhMuc_DichVu_Xoa(string Id)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Varchar2, ParameterDirection.Input, Id);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_DICHVU_XOA, paramater);
        }

        public async Task<IEnumerable<LoaiPhong>> DanhMuc_LoaiPhong_LietKe()
        {
            var paramater = _dbHelper.GetOracleDefaultParam();

            paramater.Add("cs", OracleDbType.RefCursor, ParameterDirection.Output);
            return await _dbHelper.ExecuteProcedureAsyn<LoaiPhong>(HeThongStore.PDM_LOAIPHONG_LKE, paramater);
        }

        public async Task<int> DanhMuc_LoaiPhong_Nhap(LoaiPhong danhMuc)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Int32, ParameterDirection.Input, danhMuc.ID);
            paramater.Add("p_ten", OracleDbType.NVarchar2, ParameterDirection.Input, danhMuc.TEN);
            paramater.Add("p_gia", OracleDbType.Decimal, ParameterDirection.Input, Utilities.FormatNumberToStringNumber(danhMuc.GIA));

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_LOAIPHONG_NHAP, paramater);
        }

        public async Task<int> DanhMuc_LoaiPhong_Xoa(string Id)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Varchar2, ParameterDirection.Input, Id);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_LOAIPHONG_XOA, paramater);
        }

        public async Task<IEnumerable<ThietBi>> DanhMuc_ThietBi_LietKe()
        {
            var paramater = _dbHelper.GetOracleDefaultParam();

            paramater.Add("cs", OracleDbType.RefCursor, ParameterDirection.Output);
            return await _dbHelper.ExecuteProcedureAsyn<ThietBi>(HeThongStore.PDM_THIETBI_LKE, paramater);
        }

        public async Task<int> DanhMuc_ThietBi_Nhap(ThietBi danhMuc)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Int32, ParameterDirection.Input, danhMuc.ID);
            paramater.Add("p_ten", OracleDbType.NVarchar2, ParameterDirection.Input, danhMuc.TEN);
            paramater.Add("p_nhasx", OracleDbType.NVarchar2, ParameterDirection.Input, danhMuc.NHASX);
            paramater.Add("p_gia", OracleDbType.Decimal, ParameterDirection.Input, Utilities.FormatNumberToStringNumber(danhMuc.GIA));

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_THIETBI_NHAP, paramater);
        }

        public async Task<int> DanhMuc_ThietBi_Xoa(string Id)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Varchar2, ParameterDirection.Input, Id);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_THIETBI_XOA, paramater);
        }

        public async Task<IEnumerable<Phong>> DanhMuc_Phong_LietKe()
        {
            var paramater = _dbHelper.GetOracleDefaultParam();

            paramater.Add("cs", OracleDbType.RefCursor, ParameterDirection.Output);
            return await _dbHelper.ExecuteProcedureAsyn<Phong>(HeThongStore.PDM_PHONG_LKE, paramater);
        }

        public async Task<int> DanhMuc_Phong_Nhap(Phong danhMuc)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Int32, ParameterDirection.Input, danhMuc.ID);
            paramater.Add("p_khuid", OracleDbType.Int32, ParameterDirection.Input, danhMuc.KHUID);
            paramater.Add("p_loaiid", OracleDbType.Int32, ParameterDirection.Input, danhMuc.LOAIID);
            paramater.Add("p_ten", OracleDbType.NVarchar2, ParameterDirection.Input, danhMuc.TEN);
            paramater.Add("p_soluong", OracleDbType.Int32, ParameterDirection.Input, danhMuc.SOLUONG);

            var a_thietbi = danhMuc.THIET_BI.Select(n => n.IDTHIETBI).ToArray();
            var a_SoLuong = danhMuc.THIET_BI.Select(n => n.SOLUONG).ToArray();

            paramater.AddArray<string>("a_thietbi", OracleDbType.Varchar2, a_thietbi, ParameterDirection.Input, "");
            paramater.AddArray<int>("a_soluong", OracleDbType.Int32, a_SoLuong, ParameterDirection.Input, 0);
            paramater.AddArray<string>("a_dichvu", OracleDbType.Varchar2, a_thietbi, ParameterDirection.Input, "");

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_PHONG_NHAP, paramater);

        }

        public async Task<IEnumerable<PhongDrop>> DanhMuc_Phong_Khu_LietKe(string khuId, string LoaiId)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_khu", OracleDbType.Varchar2, ParameterDirection.Input, khuId);
            paramater.Add("p_loai", OracleDbType.Varchar2, ParameterDirection.Input, LoaiId);
            paramater.Add("cs", OracleDbType.RefCursor, ParameterDirection.Output);

            return await _dbHelper.ExecuteProcedureAsyn<PhongDrop>(HeThongStore.PDM_PHONG_KHU_LKE, paramater);
        }


        public async Task<int> DanhMuc_Phong_Xoa(string Id)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Varchar2, ParameterDirection.Input, Id);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_PHONG_XOA, paramater);
        }

        public async Task<IEnumerable<PhongThietBi>> DanhMuc_Phong_ChiTiet(string Id)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();

            paramater.Add("p_id", OracleDbType.Int32, ParameterDirection.Input, Id);
            paramater.Add("cs", OracleDbType.RefCursor, ParameterDirection.Output);
            return await _dbHelper.ExecuteProcedureAsyn<PhongThietBi>(HeThongStore.PDM_PHONG_CT, paramater);
        }

        public async Task<int> DanhMuc_Phong_ChiTiet_Xoa(string IdPhong, string IdThietBi)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_phongid", OracleDbType.Int32, ParameterDirection.Input, IdPhong);
            paramater.Add("p_thietbi", OracleDbType.Int32, ParameterDirection.Input, IdThietBi);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_PHONG_CT_XOA, paramater);
        }

        public async Task<IEnumerable<SinhVien>> DanhMuc_SinhVien_LietKe()
        {
            var paramater = _dbHelper.GetOracleDefaultParam();

            paramater.Add("cs", OracleDbType.RefCursor, ParameterDirection.Output);
            return await _dbHelper.ExecuteProcedureAsyn<SinhVien>(HeThongStore.PDM_SINHVIEN_LKE, paramater);
        }

        public async Task<int> DanhMuc_SinhVien_Nhap(SinhVien danhMuc)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_ma", OracleDbType.NVarchar2, ParameterDirection.Input, danhMuc.MA);
            paramater.Add("p_ten", OracleDbType.NVarchar2, ParameterDirection.Input, danhMuc.TEN);
            paramater.Add("p_khoa", OracleDbType.NVarchar2, ParameterDirection.Input, danhMuc.KHOA);
            paramater.Add("p_sdt", OracleDbType.Varchar2, ParameterDirection.Input, danhMuc.DIENTHOAI);
            paramater.Add("p_ngaysinh", OracleDbType.Varchar2, ParameterDirection.Input, danhMuc.NGAYSINH);
            paramater.Add("p_email", OracleDbType.Varchar2, ParameterDirection.Input, danhMuc.EMAIL);
            paramater.Add("p_cmt", OracleDbType.Varchar2, ParameterDirection.Input, danhMuc.CHUNGMINHTHU);
            paramater.Add("p_gioitinh", OracleDbType.NVarchar2, ParameterDirection.Input, danhMuc.GIOITINH);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_SINHVIEN_NHAP, paramater);
        }

        public async Task<int> DanhMuc_SinhVien_Xoa(string Id)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_ma", OracleDbType.NVarchar2, ParameterDirection.Input, Id);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_SINHVIEN_XOA, paramater);
        }

        public async Task<IEnumerable<NhanVien>> DanhMuc_NhanVien_LietKe()
        {
            var paramater = _dbHelper.GetOracleDefaultParam();

            paramater.Add("cs", OracleDbType.RefCursor, ParameterDirection.Output);
            return await _dbHelper.ExecuteProcedureAsyn<NhanVien>(HeThongStore.PDM_NHANVIEN_LKE, paramater);
        }

        public async Task<int> DanhMuc_NhanVien_Nhap(NhanVien danhMuc)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Int32, ParameterDirection.Input, danhMuc.ID);
            paramater.Add("p_chucvuid", OracleDbType.Int32, ParameterDirection.Input, danhMuc.CHUCVUID);
            paramater.Add("p_ten", OracleDbType.NVarchar2, ParameterDirection.Input, danhMuc.TEN);
            paramater.Add("p_dienthoai", OracleDbType.Varchar2, ParameterDirection.Input, danhMuc.DIENTHOAI);
            paramater.Add("p_ngaysinh", OracleDbType.Varchar2, ParameterDirection.Input, danhMuc.NGAYSINH);
            paramater.Add("p_email", OracleDbType.Varchar2, ParameterDirection.Input, danhMuc.EMAIL);
            paramater.Add("p_gioitinh", OracleDbType.NVarchar2, ParameterDirection.Input, danhMuc.GIOITINH);


            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_NHANVIEN_NHAP, paramater);

        }

        public async Task<int> DanhMuc_NhanVien_Xoa(string Id)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_id", OracleDbType.Varchar2, ParameterDirection.Input, Id);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_NHANVIEN_XOA, paramater);
        }

        public async Task<Tuple<IEnumerable<SinhVien_Phong>, IEnumerable<PhongThietBi>>> NghiepVu_SinHVien_PhongDK(string phongId)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_phongid", OracleDbType.Varchar2, ParameterDirection.Input, phongId);

            paramater.Add("cs", OracleDbType.RefCursor, ParameterDirection.Output);
            paramater.Add("cs1", OracleDbType.RefCursor, ParameterDirection.Output);
            return await _dbHelper.ExecuteProcedureAsyn<SinhVien_Phong, PhongThietBi>(HeThongStore.PNV_SINHVIEN_PHONG_DK, paramater);
        }


        public async Task<int> NghiepVu_SinhVien_DangKy_Nhap(SinhVien_DangKy danhMuc)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_khuid", OracleDbType.Int32, ParameterDirection.Input, danhMuc.KHUID);
            paramater.Add("p_loaiid", OracleDbType.Int32, ParameterDirection.Input, danhMuc.LOAIID);
            paramater.Add("p_phongid", OracleDbType.Int32, ParameterDirection.Input, danhMuc.PHONGID);
            paramater.Add("p_sinhvienid", OracleDbType.Varchar2, ParameterDirection.Input, danhMuc.SINHVIENID); 
            paramater.Add("p_thangd", OracleDbType.Int32, ParameterDirection.Input, Utilities.MonthToNumber(danhMuc.TUTHANG));
            paramater.Add("p_thangc", OracleDbType.Int32, ParameterDirection.Input, Utilities.MonthToNumber(danhMuc.DENTHANG));


            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PNV_SINHVIEN_DANGKY_NHAP, paramater);
        }

        public async Task<IEnumerable<SinhVien_DangKy>> NghiepVu_SinhVien_DangKy_Lke()
        {
            var paramater = _dbHelper.GetOracleDefaultParam(); 

            paramater.Add("cs", OracleDbType.RefCursor, ParameterDirection.Output); 
            return await _dbHelper.ExecuteProcedureAsyn<SinhVien_DangKy>(HeThongStore.PNV_SINHVIEN_DANGKY_LKE, paramater);
        }

        public async Task<int> DanhMuc_SinhVien_DangKy_Xoa(string phongId)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_phongid", OracleDbType.Varchar2, ParameterDirection.Input, phongId);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_NHANVIEN_XOA, paramater);
        }

        public async Task<int> DanhMuc_SinhVien_DangKy_ct_Xoa(string phongId, string sinhvienId)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_phongid", OracleDbType.Varchar2, ParameterDirection.Input, phongId);
            paramater.Add("p_sinhvienid", OracleDbType.Varchar2, ParameterDirection.Input, sinhvienId);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PDM_NHANVIEN_XOA, paramater);
        }

        public async Task<int> Phong_ThietBi_BapHong_nhap(string phongId, string thietbiid, string Noidung)
        {
            var paramater = _dbHelper.GetOracleDefaultParam();
            paramater.Add("p_phongid", OracleDbType.Varchar2, ParameterDirection.Input, phongId);
            paramater.Add("p_thietbi", OracleDbType.Varchar2, ParameterDirection.Input, thietbiid);
            paramater.Add("p_noidung", OracleDbType.Varchar2, ParameterDirection.Input, Noidung);

            return await _dbHelper.ExecuteNoneQueryAsyn(HeThongStore.PPHONG_THIETBI_HONG_NHAP, paramater);
        }
    }
}
