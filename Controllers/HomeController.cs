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
        Juego.IniciarJuego();
        ViewBag.palabraMostrar = Juego.palabraMostrar;
        ViewBag.letrasUsadas = Juego.letrasUsadas;
        ViewBag.intentos = Juego.intentos;
        ViewBag.palabraAdivinar= Juego.palabraAdivinar;
        switch(Juego.intentos)
        {
            case 0:
            ViewBag.FOTOAHORCADO = "INTENTOS0.png";
            break;
            case 1:
            ViewBag.FOTOAHORCADO = "INTENTOS1.png";
            break;
            case 2:
            ViewBag.FOTOAHORCADO = "INTENTOS2.png";
            break;
            case 3:
            ViewBag.FOTOAHORCADO = "INTENTOS3.png";
            break;
            case 4:
            ViewBag.FOTOAHORCADO = "INTENTOS4.png";
            break;
            case 5:
            ViewBag.FOTOAHORCADO = "INTENTOS5.png";
            break;
            default:
            ViewBag.FOTOAHORCADO = "INTENTOS6.png";
            break;
        }
        return View("Ahorcado");
    }
    public IActionResult ArriesgarLetra(char letra)
    {

        Juego.ArriesgarLetra(letra);
        ViewBag.palabraMostrar = Juego.palabraMostrar;
        ViewBag.letrasUsadas = Juego.letrasUsadas;
        ViewBag.intentos = Juego.intentos;
        ViewBag.palabraAdivinar= Juego.palabraAdivinar;
        switch(Juego.intentos)
        {
            case 0:
            ViewBag.FOTOAHORCADO = "INTENTOS0.png";
            break;
            case 1:
            ViewBag.FOTOAHORCADO = "INTENTOS1.png";
            break;
            case 2:
            ViewBag.FOTOAHORCADO = "INTENTOS2.png";
            break;
            case 3:
            ViewBag.FOTOAHORCADO = "INTENTOS3.png";
            break;
            case 4:
            ViewBag.FOTOAHORCADO = "INTENTOS4.png";
            break;
            case 5:
            ViewBag.FOTOAHORCADO = "INTENTOS5.png";
            break;
            default:
            ViewBag.FOTOAHORCADO = "INTENTOS6.png";
            break;
        }
        if(Juego.palabraMostrar == Juego.palabraAdivinar)
       {
            return View("Gano");
       }
       if(Juego.intentos==7)
       {
           return View("Perdio");
       }
        return View("Ahorcado");
    }
    public IActionResult ArriesgarPalabra(string palabra)
    {
        if (Juego.ArriesgarPalabra(palabra))
        {
            return View("Gano");
        }
        else
        {
            return View("Perdio");
        }
    }
}
