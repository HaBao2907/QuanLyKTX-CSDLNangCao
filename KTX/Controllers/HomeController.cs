using LibNetCore.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace KTX.Controllers
{
    public class HomeController : BaseController
    { 
        public HomeController()
        { 
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SinhVien()
        {
            return View();
        }

        public IActionResult NhanVien()
        {
            return View();
        }

    }
}