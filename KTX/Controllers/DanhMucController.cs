using LibNetCore.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace KTX.Controllers
{
    public class DanhMucController : BaseController
    {
        public IActionResult BoPhan()
        {
            return View();
        }
        public IActionResult ChucVu()
        {
            return View();
        }
        public IActionResult DichVu()
        {
            return View();
        }

        public IActionResult ThietBi()
        {
            return View();
        }

        public IActionResult LoaiPhong()
        {
            return View();
        }
        public IActionResult khu()
        {
            return View();
        }
        public IActionResult Phong()
        {
            return View();
        }
    }
}
