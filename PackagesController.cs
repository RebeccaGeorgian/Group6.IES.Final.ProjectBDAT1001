using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationUser.Controllers
{
    [Authorize(Roles = "Admin")]
    public class PackagesController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
