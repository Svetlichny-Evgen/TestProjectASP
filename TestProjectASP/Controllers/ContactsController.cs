using Microsoft.AspNetCore.Mvc;

namespace TestProjectASP.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
