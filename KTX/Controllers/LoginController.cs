using LibNetCore.Constants;
using LibNetCore.Controllers;
using LibNetCore.Session;
using Microsoft.AspNetCore.Mvc;

namespace KTX.Controllers
{
    public class LoginController : BaseController
    {
        private ISessionHelper _sessionHelper;

        public LoginController(ISessionHelper sessionHelper)
        {
            _sessionHelper = sessionHelper;
        }
        public IActionResult Index()
        {
            _sessionHelper.SaveSession(Config.USER_SESSION, "");
            _sessionHelper.SaveSession(Config.DB_NAME, "");
            return View();
        }
    }
}
