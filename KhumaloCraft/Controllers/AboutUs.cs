using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult AboutUs()
    {
        return View();
    }
}
