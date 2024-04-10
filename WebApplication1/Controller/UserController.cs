using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controller;

public class UserController : Microsoft.AspNetCore.Mvc.Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}