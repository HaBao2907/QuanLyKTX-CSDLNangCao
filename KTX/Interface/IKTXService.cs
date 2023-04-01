using KTX.Model;

namespace KTX.Interface
{
    public interface IKTXService
    {
        Task<IEnumerable<DanhMucChung>> DanhMuc_BoPhan_LietKe();
        Task<int> DanhMuc_BoPhan_Nhap(DanhMucChung danhMuc);
        Task<int> DanhMuc_BoPhan_Xoa(string Id);

        Task<IEnumerable<DanhMucChung>> DanhMuc_ChucVu_LietKe();
        Task<int> DanhMuc_ChucVu_Nhap(DanhMucChung danhMuc);
        Task<int> DanhMuc_ChucVu_Xoa(string Id);

        Task<IEnumerable<DanhMucChung>> DanhMuc_Khu_LietKe();
        Task<int> DanhMuc_Khu_Nhap(DanhMucChung danhMuc);
        Task<int> DanhMuc_Khu_Xoa(string Id);

        Task<IEnumerable<LoaiPhong>> DanhMuc_DichVu_LietKe();
        Task<int> DanhMuc_DichVu_Nhap(LoaiPhong danhMuc);
        Task<int> DanhMuc_DichVu_Xoa(string Id);

        Task<IEnumerable<LoaiPhong>> DanhMuc_LoaiPhong_LietKe();
        Task<int> DanhMuc_LoaiPhong_Nhap(LoaiPhong danhMuc);
        Task<int> DanhMuc_LoaiPhong_Xoa(string Id);

        Task<IEnumerable<ThietBi>> DanhMuc_ThietBi_LietKe();
        Task<int> DanhMuc_ThietBi_Nhap(ThietBi danhMuc);
        Task<int> DanhMuc_ThietBi_Xoa(string Id);

        Task<IEnumerable<Phong>> DanhMuc_Phong_LietKe();
        Task<IEnumerable<PhongDrop>> DanhMuc_Phong_Khu_LietKe(string khuId, string LoaiId);
        Task<IEnumerable<PhongThietBi>> DanhMuc_Phong_ChiTiet(string Id);
        Task<int> DanhMuc_Phong_Nhap(Phong danhMuc);
        Task<int> DanhMuc_Phong_Xoa(string Id);
        Task<int> DanhMuc_Phong_ChiTiet_Xoa(string IdPhong, string IdThietBi);

        Task<IEnumerable<SinhVien>> DanhMuc_SinhVien_LietKe();
        Task<int> DanhMuc_SinhVien_Nhap(SinhVien danhMuc);
        Task<int> DanhMuc_SinhVien_Xoa(string Id);

        Task<IEnumerable<NhanVien>> DanhMuc_NhanVien_LietKe();
        Task<int> DanhMuc_NhanVien_Nhap(NhanVien danhMuc);
        Task<int> DanhMuc_NhanVien_Xoa(string Id);


        //NV
        Task<Tuple< IEnumerable<SinhVien_Phong>, IEnumerable<PhongThietBi>>> NghiepVu_SinHVien_PhongDK(string phongId);
        Task<int> NghiepVu_SinhVien_DangKy_Nhap(SinhVien_DangKy danhMuc);
        Task<IEnumerable<SinhVien_DangKy>> NghiepVu_SinhVien_DangKy_Lke();
        Task<int> DanhMuc_SinhVien_DangKy_Xoa(string phongId);
        Task<int> DanhMuc_SinhVien_DangKy_ct_Xoa(string phongId, string sinhvienId);


                                        
        Task<int> Phong_ThietBi_BapHong_nhap(string phongId, string thietbiid, string Noidung);
    }
}
