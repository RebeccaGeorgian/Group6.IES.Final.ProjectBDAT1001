using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationUser.Controllers
{
    [Authorize]
    public class ServicesController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
