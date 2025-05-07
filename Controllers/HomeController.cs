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
        return View();
    }
    public IActionResult ElegirPalabra()
    {
        ViewBag.palabra = Palabras.ElegirPalabra();
        return View("Ahorcado");
    }
    public IActionResult ArriesgarLetra(char Letra, string palabra)
    {
        bool adivino = false;
        for(int i = 0; i > palabra.Length - 1; i++)
        {
            if (palabra[i] == Letra)
            {
              adivino = true;
            }
        }
        return View();
    }
    public IActionResult ArriesgarPalabra(string Palabra)
    {
        return View();
    }
}
