using System.ComponentModel.DataAnnotations;

namespace KTX.Model
{
    public class DanhMucChung
    {
        public string ID { get; set; }
        [Required(ErrorMessage ="Tên không được nhập trống")]
        [MaxLength(400, ErrorMessage ="Độ dài không vượt quá 400 ký tự")]
        public string TEN { get; set; }
    }
}
