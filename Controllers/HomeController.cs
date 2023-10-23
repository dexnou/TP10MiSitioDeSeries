using Microsoft.AspNetCore.Mvc;

namespace TP10MiSitioDeSeries.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaSeries = BD.CargarSeries();
        return View();
    }

    public IActionResult VerDetallesActores(int IdActor){
        return BD.VerActores(IdActor);
    }
    
    public IActionResult VerDetallesTemporadas(int IdTemporada){
        return BD.VerTemporadas(IdTemporada);
    }


    



}
