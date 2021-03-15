using Microsoft.AspNetCore.Mvc;

namespace Netchat.Controllers
{
    public class Homecontroller : Controller
    {
        public IActionResult Index() => View();
    }
}