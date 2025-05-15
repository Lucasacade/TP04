using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04.Models;

namespace TP04.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View("Index");
    }
    public IActionResult ElegirPalabra()
    {
        Juego.CargarPalabras();
        ViewBag.palabraMostrar = Juego.palabraMostrar;
        ViewBag.letrasUsadas = Juego.letrasUsadas;
        ViewBag.intentos = Juego.intentos;
        ViewBag.finalizado = Juego.finalizado;
        return View("Ahorcado");
    }
    public IActionResult ArriesgarLetra(string letra)
    {
        Juego.ArriesgarLetra(letra[0]);
        return View("Ahorcado");
    }
    public IActionResult ArriesgarPalabra(string Palabra)
    {
        return View("Ahorcado");
    }
}
