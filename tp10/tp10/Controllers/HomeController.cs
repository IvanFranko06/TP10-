using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using tp10.Models;

namespace tp10.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Serie = BD.SeleccionS();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
public Serie verDetalleSerie(int IdSerie){
    return BD.SeleccionS2(IdSerie);
}

public List<Temporada> verTemporada(int IdSerie){
return BD.SeleccionT(IdSerie);
}
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

