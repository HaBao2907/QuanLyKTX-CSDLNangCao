using System.ComponentModel.DataAnnotations;

namespace KTX.Model
{
    public class LoaiPhong
    {
        public string ID { get; set; }
        [Required(ErrorMessage ="Tên loại phòng không nhập trống")]
        public string TEN { get; set; }
        public string GIA { get; set; }
    }
}
