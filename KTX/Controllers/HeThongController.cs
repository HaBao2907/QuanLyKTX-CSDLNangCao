using KTX.Interface;
using KTX.Model;
using LibNetCore.Constants;
using LibNetCore.Json;
using LibNetCore.Model;
using LibNetCore.Session;
using LibNetCore.Web;
using Microsoft.AspNetCore.Mvc;

namespace KTX.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeThongController : ControllerBase
    {
        private ISessionHelper _sessionHelper;
        private IHeThongService _heThongSerVice;


        public HeThongController(ISessionHelper sessionHelper, IHeThongService heThongSerVice)
        {
            _sessionHelper = sessionHelper;
            _heThongSerVice = heThongSerVice;
        }

        [HttpPost]
        [Route("DangNhapHeThong")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DangNhapHeThong([FromQuery] string taiKhoan, [FromQuery] string matKhau, [FromQuery] string Remember)
        {
            try
            {
                IEnumerable<NguoiDung> kh = await _heThongSerVice.HeThong_DangNhapHeThong(taiKhoan, matKhau);

                if (kh.Count() == 0)
                {
                    throw new Exception("loi:Tài khoản hoặc mật khẩu không chính xác:loi");
                }
                 
                NguoiDung nsd = kh.FirstOrDefault(); 

                if (Remember == "C")
                {
                    var options = new CookieOptions()
                    {
                        Expires = DateTime.Now.AddDays(360),
                        HttpOnly = false
                    };

                    HttpContext.Response.Cookies.Append("REMEMBERPW", nsd.ToJson(), options);
                }

                NguoiSuDung nguoiSuDung = new NguoiSuDung();
                nguoiSuDung.TenDangNhap = taiKhoan; 
                nguoiSuDung.TenDaiDien = nsd.Ten;
                nguoiSuDung.Id = nsd.Ten;
                nguoiSuDung.MaDonVi="ID";

                _sessionHelper.SaveSession(Config.USER_SESSION, nguoiSuDung.ToJson());

                string token = Jwt.GenerateToken(nguoiSuDung);
                HttpContext.Response.Cookies.Append("TOKEN", token,
                    new CookieOptions() { HttpOnly = true });

                return Ok(new { url = "/Home", nsd=nguoiSuDung });

            }
            catch (Exception ex)
            {
                _sessionHelper.SaveSession(Config.USER_SESSION, "");
                _sessionHelper.SaveSession(Config.DB_NAME, "");
                return BadRequest(ex.Message);
            }
        }

    }
}
