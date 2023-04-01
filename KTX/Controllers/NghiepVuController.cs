using LibNetCore.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace KTX.Controllers
{
    public class NghiepVuController : BaseController
    {
        public IActionResult DangKy()
        {
            return View();
        }
        public IActionResult BaoHong()
        {
            return View();
        }
        public IActionResult ThanhToanDichVu()
        {
            return View();
        }
    }
}
