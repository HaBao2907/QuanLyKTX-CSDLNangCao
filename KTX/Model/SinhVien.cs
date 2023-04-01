using System.ComponentModel.DataAnnotations;

namespace KTX.Model
{
    public class SinhVien
    {
        [Required(ErrorMessage ="Mã sinh viên không  nhập trống")]
        public string MA { get; set; }
        [Required(ErrorMessage ="Tên sinh viên không nhập trống")]
        public string TEN { get; set; }
        public string KHOA { get; set; }
        [Required(ErrorMessage = "Số điện thoại sinh viên không nhập trống")]
        public string DIENTHOAI { get; set; }
        public string NGAYSINH { get; set; }
        public string EMAIL { get; set; }
        public string CHUNGMINHTHU { get; set; }
        public string GIOITINH { get; set; }
    }

    public class SinhVien_DangKy
    {
        [Required(ErrorMessage = "Chưa chọn sinh viên đăng ký")]
        public string SINHVIENID { get; set; }
        [Required(ErrorMessage = "Chưa chọn khu")]
        public string KHUID { get; set; }
        public string KHU { get; set; }
        [Required(ErrorMessage = "Chưa chọn loại phòng")]
        public string LOAIID { get; set; }
        public string LOAI { get; set; }
        [Required(ErrorMessage = "Chưa chọn phòng")]
        public string PHONGID { get; set; }
        public string PHONG { get; set; }
        public string DANG_KY { get; set; }
        public string GIA { get; set; }
        [Required(ErrorMessage ="Từ tháng không nhập trống")]
        public string TUTHANG { get; set; }
        [Required(ErrorMessage = "Đến tháng không nhập trống")]
        public string DENTHANG { get; set; }
    }

    public class SinhVien_Phong
    {
        public string PHONGID { get; set; }
        public string SINHVIENID { get; set; }
        public string TEN { get; set; }
        public string KHOA { get; set; }
        public string TUTHANG { get; set; }
        public string DENTHANG { get; set; }
        public string THOI_GIAN { get; set; }
    }
}
