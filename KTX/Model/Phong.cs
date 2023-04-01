using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace KTX.Model
{
    public class PhongDrop
    {
        public string ID { get; set; }
        public string TEN { get; set; }
    }

    public class Phong
    {
        public string ID { get; set; }
        public string LOAIID { get; set; }
        public string LOAI { get; set; }
        public string KHUID { get; set; }
        public string KHU { get; set; }
        [Required(ErrorMessage = "Tên phòng không nhập trống")]
        public string TEN { get; set; }
        [Required(ErrorMessage = "Phải nhập số lượng người được phép trong phòng")]
        public string SOLUONG { get; set; }
        public IEnumerable<PhongThietBi> THIET_BI { get; set; }
        public IEnumerable<PhongDichVu> DICH_VU { get; set; }
    }
    public class PhongThietBi
    {
        public string PHONGID { get; set; }
        public string IDTHIETBI { get; set; }
        public string THIETBI { get; set; }
        public int SOLUONG { get; set; }
        public string TRANG_THAI { get; set; }
    }

    public class PhongDichVu
    {
        public string DICHVUID { get; set; }
        public string DICHVu { get; set; }
    }

}
