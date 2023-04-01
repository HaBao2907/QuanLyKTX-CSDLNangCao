using System.ComponentModel.DataAnnotations;

namespace KTX.Model
{
    public class ThietBi
    {
        public string ID { get; set; }
        [Required(ErrorMessage ="Nhập tên thiết bị")]
        public string TEN { get; set; }
        public string NHASX { get; set; }
        public string GIA { get; set; }
    }
}
