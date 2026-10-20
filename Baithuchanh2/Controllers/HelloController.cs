using Microsoft.AspNetCore.Mvc;

namespace Baithuchanh2.Controllers
{
    public class HelloController : Controller
    {
        public string Greeting()
        {
            return "Hello, world!";
        }
        public String Welcome(int id, string name)
        {
                       return $"Welcome {id} - {name}, chao mung!";
        }
        public IActionResult Welcome1(int id1, String name)
        {
            ViewBag.id1 = id1;
            ViewBag.name = name;
            ViewData["name"] = name;
            ViewData["Message"] = $"Welcome {id1} - {name}, chao mung!";
            return View();
        }
    }
}
