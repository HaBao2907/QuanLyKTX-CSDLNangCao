using System.ComponentModel.DataAnnotations;

namespace KTX.Model
{
    public class NhanVien
    {
        public string ID { get; set; }
        [Required(ErrorMessage ="Chưa chọn thông tin chức vụ")]
        public string CHUCVUID { get; set; }
        public string CHUCVU { get; set; }
        [Required(ErrorMessage = "Chưa chọn thông tin tên")]
        public string TEN { get; set; }
        public string DIENTHOAI { get; set; }
        public string NGAYSINH { get; set; }
        public string EMAIL { get; set; }
        public string GIOITINH { get; set; }
    }


}
