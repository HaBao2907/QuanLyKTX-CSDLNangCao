using KTX.Interface;
using KTX.Model;
using LibNetCore.Session;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KTX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KTXController : ControllerBase
    {
        private ISessionHelper _sessionHelper;
        private IKTXService _ktxService;


        public KTXController(ISessionHelper sessionHelper, IKTXService ktxService)
        {
            _sessionHelper = sessionHelper;
            _ktxService = ktxService;
        }

        [HttpGet]
        [Route("DanhMuc_BoPhan_LietKe")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_BoPhan_LietKe()
        {
            var ketQua = await _ktxService.DanhMuc_BoPhan_LietKe();
            return Ok(ketQua);
        }

        [HttpPost]
        [Route("DanhMuc_BoPhan_Nhap")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_BoPhan_Nhap([FromBody] DanhMucChung mucChung)
        {
            await _ktxService.DanhMuc_BoPhan_Nhap(mucChung);

            var ketQua = await _ktxService.DanhMuc_BoPhan_LietKe();
            return Ok(ketQua);
        }

        [HttpGet]
        [Route("DanhMuc_BoPhan_Xoa")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_BoPhan_Xoa([FromQuery] string Id)
        {
            await _ktxService.DanhMuc_BoPhan_Xoa(Id);
            return Ok("Xóa thành công");
        }

        [HttpGet]
        [Route("DanhMuc_ChucVu_LietKe")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_ChucVu_LietKe()
        {
            var ketQua = await _ktxService.DanhMuc_ChucVu_LietKe();
            return Ok(ketQua);
        }

        [HttpPost]
        [Route("DanhMuc_ChucVu_Nhap")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_ChucVu_Nhap([FromBody] DanhMucChung mucChung)
        {
            await _ktxService.DanhMuc_ChucVu_Nhap(mucChung);

            var ketQua = await _ktxService.DanhMuc_ChucVu_LietKe();
            return Ok(ketQua);
        }

        [HttpGet]
        [Route("DanhMuc_ChucVu_Xoa")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_ChucVu_Xoa([FromQuery] string Id)
        {
            await _ktxService.DanhMuc_ChucVu_Xoa(Id);
            return Ok("Xóa thành công");
        }

        [HttpGet]
        [Route("DanhMuc_Khu_LietKe")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_Khu_LietKe()
        {
            var ketQua = await _ktxService.DanhMuc_Khu_LietKe();
            return Ok(ketQua);
        }

        [HttpPost]
        [Route("DanhMuc_Khu_Nhap")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_Khu_Nhap([FromBody] DanhMucChung mucChung)
        {
            await _ktxService.DanhMuc_Khu_Nhap(mucChung);

            var ketQua = await _ktxService.DanhMuc_Khu_LietKe();
            return Ok(ketQua);
        }

        [HttpGet]
        [Route("DanhMuc_Khu_Xoa")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_Khu_Xoa([FromQuery] string Id)
        {
            await _ktxService.DanhMuc_Khu_Xoa(Id);
            return Ok("Xóa thành công");
        }


        [HttpGet]
        [Route("DanhMuc_LoaiPhong_LietKe")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_LoaiPhong_LietKe()
        {
            var ketQua = await _ktxService.DanhMuc_LoaiPhong_LietKe();
            return Ok(ketQua);
        }

        [HttpGet]
        [Route("DanhMuc_Phong_Khu_LietKe")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_Phong_Khu_LietKe([FromQuery] string khuid, [FromQuery] string loaiid)
        {
            var ketQua = await _ktxService.DanhMuc_Phong_Khu_LietKe(khuid, loaiid);
            return Ok(ketQua);
        }

        [HttpPost]
        [Route("DanhMuc_LoaiPhong_Nhap")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_LoaiPhong_Nhap([FromBody] LoaiPhong mucChung)
        {
            await _ktxService.DanhMuc_LoaiPhong_Nhap(mucChung);

            var ketQua = await _ktxService.DanhMuc_LoaiPhong_LietKe();
            return Ok(ketQua);
        }

        [HttpGet]
        [Route("DanhMuc_LoaiPhong_Xoa")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_LoaiPhong_Xoa([FromQuery] string Id)
        {
            await _ktxService.DanhMuc_LoaiPhong_Xoa(Id);
            return Ok("Xóa thành công");
        }


        [HttpGet]
        [Route("DanhMuc_DichVu_LietKe")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_DichVu_LietKe()
        {
            var ketQua = await _ktxService.DanhMuc_DichVu_LietKe();
            return Ok(ketQua);
        }

        [HttpPost]
        [Route("DanhMuc_DichVu_Nhap")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_DichVu_Nhap([FromBody] LoaiPhong mucChung)
        {
            await _ktxService.DanhMuc_DichVu_Nhap(mucChung);

            var ketQua = await _ktxService.DanhMuc_DichVu_LietKe();
            return Ok(ketQua);
        }

        [HttpGet]
        [Route("DanhMuc_DichVu_Xoa")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_DichVu_Xoa([FromQuery] string Id)
        {
            await _ktxService.DanhMuc_DichVu_Xoa(Id);
            return Ok("Xóa thành công");
        }



        [HttpGet]
        [Route("DanhMuc_ThietBi_LietKe")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_ThietBi_LietKe()
        {
            var ketQua = await _ktxService.DanhMuc_ThietBi_LietKe();
            return Ok(ketQua);
        }

        [HttpPost]
        [Route("DanhMuc_ThietBi_Nhap")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_ThietBi_Nhap([FromBody] ThietBi mucChung)
        {
            await _ktxService.DanhMuc_ThietBi_Nhap(mucChung);

            var ketQua = await _ktxService.DanhMuc_ThietBi_LietKe();
            return Ok(ketQua);
        }

        [HttpGet]
        [Route("DanhMuc_ThietBi_Xoa")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_ThietBi_Xoa([FromQuery] string Id)
        {
            await _ktxService.DanhMuc_ThietBi_Xoa(Id);
            return Ok("Xóa thành công");
        }



        [HttpGet]
        [Route("DanhMuc_Phong_LietKe")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_Phong_LietKe()
        {
            var ketQua = await _ktxService.DanhMuc_Phong_LietKe();
            return Ok(ketQua);
        }

        [HttpPost]
        [Route("DanhMuc_Phong_Nhap")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_Phong_Nhap([FromBody] Phong mucChung)
        {
            await _ktxService.DanhMuc_Phong_Nhap(mucChung);

            var ketQua = await _ktxService.DanhMuc_Phong_LietKe();
            return Ok(ketQua);
        }

        [HttpGet]
        [Route("DanhMuc_Phong_Xoa")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_Phong_Xoa([FromQuery] string Id)
        {
            await _ktxService.DanhMuc_Phong_Xoa(Id);
            return Ok("Xóa thành công");
        }

        [HttpGet]
        [Route("DanhMuc_Phong_ChiTiet_Xoa")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_Phong_ChiTiet_Xoa([FromQuery] string IdPhong, [FromQuery] string IdThietBi)
        {
            await _ktxService.DanhMuc_Phong_ChiTiet_Xoa(IdPhong, IdThietBi);
            return Ok("Xóa thành công");
        }

        [HttpGet]
        [Route("DanhMuc_Phong_ChiTiet")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_Phong_ChiTiet([FromQuery] string IdPhong)
        {
            var KetQua = await _ktxService.DanhMuc_Phong_ChiTiet(IdPhong);
            return Ok(KetQua);
        }


        [HttpGet]
        [Route("DanhMuc_SinhVien_LietKe")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_SinhVien_LietKe()
        {
            var ketQua = await _ktxService.DanhMuc_SinhVien_LietKe();
            return Ok(ketQua);
        }

        [HttpPost]
        [Route("DanhMuc_SinhVien_Nhap")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_SinhVien_Nhap([FromBody] SinhVien mucChung)
        {
            await _ktxService.DanhMuc_SinhVien_Nhap(mucChung);

            var ketQua = await _ktxService.DanhMuc_SinhVien_LietKe();
            return Ok(ketQua);
        }

        [HttpGet]
        [Route("DanhMuc_SinhVien_Xoa")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_SinhVien_Xoa([FromQuery] string Id)
        {
            await _ktxService.DanhMuc_SinhVien_Xoa(Id);
            return Ok("Xóa thành công");
        }


        [HttpGet]
        [Route("DanhMuc_NhanVien_LietKe")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_NhanVien_LietKe()
        {
            var ketQua = await _ktxService.DanhMuc_NhanVien_LietKe();
            return Ok(ketQua);
        }

        [HttpPost]
        [Route("DanhMuc_NhanVien_Nhap")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_NhanVien_Nhap([FromBody] NhanVien mucChung)
        {
            await _ktxService.DanhMuc_NhanVien_Nhap(mucChung);

            var ketQua = await _ktxService.DanhMuc_NhanVien_LietKe();
            return Ok(ketQua);
        }

        [HttpGet]
        [Route("DanhMuc_NhanVien_Xoa")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_NhanVien_Xoa([FromQuery] string Id)
        {
            await _ktxService.DanhMuc_NhanVien_Xoa(Id);
            return Ok("Xóa thành công");
        }

        [HttpGet]
        [Route("NghiepVu_SinHVien_PhongDK")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NghiepVu_SinHVien_PhongDK([FromQuery] string phongId)
        {
            var ketQua = await _ktxService.NghiepVu_SinHVien_PhongDK(phongId);
            return Ok(ketQua);
        }

        [HttpGet]
        [Route("NghiepVu_SinHVien_DangKy_Lke")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NghiepVu_SinHVien_DangKy_Lke()
        {
            var ketQua = await _ktxService.NghiepVu_SinhVien_DangKy_Lke();
            return Ok(ketQua);
        }

        [HttpPost]
        [Route("NghiepVu_SinhVien_DangKy_Nhap")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NghiepVu_SinhVien_DangKy_Nhap([FromBody] SinhVien_DangKy dangKy)
        {
            await _ktxService.NghiepVu_SinhVien_DangKy_Nhap(dangKy);

            var ketQua = await _ktxService.NghiepVu_SinhVien_DangKy_Lke();
            return Ok(ketQua);
        }

        [HttpGet]
        [Route("DanhMuc_SinhVien_DangKy_Xoa")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_SinhVien_DangKy_Xoa([FromQuery]string phongId)
        {
            await _ktxService.DanhMuc_SinhVien_DangKy_Xoa(phongId); 
            return Ok("Thành công");
        }

        [HttpGet]
        [Route("DanhMuc_SinhVien_DangKy_ct_Xoa")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DanhMuc_SinhVien_DangKy_ct_Xoa([FromQuery] string phongId, [FromQuery] string sinhvienId)
        {
            await _ktxService.DanhMuc_SinhVien_DangKy_ct_Xoa(phongId, sinhvienId);
            return Ok("Thành công");
        }

        [HttpPost]
        [Route("Phong_ThietBi_BapHong_nhap")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Phong_ThietBi_BapHong_nhap([FromBody] BaoHong baoHong)
        {
            await _ktxService.Phong_ThietBi_BapHong_nhap(baoHong.PHONGID, baoHong.THIETBIID, baoHong.NOIDUNG);
            return Ok("Thành công");
        }
    }
}
