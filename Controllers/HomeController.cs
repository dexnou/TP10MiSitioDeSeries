using Microsoft.AspNetCore.Mvc;

namespace TP10MiSitioDeSeries.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
