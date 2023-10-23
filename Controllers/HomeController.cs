using Microsoft.AspNetCore.Mvc;
using TP10MiSitioDeSeries.Models;

namespace TP10MiSitioDeSeries.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaSeries = BD.CargarSeries();
        return View();
    }

    public List<Actores> VerDetallesActores(int IdSerie){
        return BD.VerActores(IdSerie);
    }
    
    public List<Temporadas> VerDetallesTemporadas(int IdSerie){
        return BD.VerTemporadas(IdSerie);
    }

    public Series VerDetallesSerie(int IdSerie){

        return BD.VerSerie(IdSerie);
    }


    



}
