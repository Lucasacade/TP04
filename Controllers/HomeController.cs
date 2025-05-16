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
        Juego.CargarPalabras();
        ViewBag.palabraMostrar = Juego.palabraMostrar;
        ViewBag.letrasUsadas = Juego.letrasUsadas;
        ViewBag.intentos = Juego.intentos;
        ViewBag.finalizado = Juego.finalizado;
        return View("Ahorcado");
    }
    public IActionResult ArriesgarLetra(char letra)
    {
        ViewBag.cantLetrasPalabra = Juego.palabraAdivinar.Length;
        Juego.ArriesgarLetra(letra, false);
        if(Juego.ganaste)
        {
            return RedirectToAction("Gano");
        }
        else if(Juego.perdiste)
        {
            return RedirectToAction("Perdio");
        }
        return View("Ahorcado");
    }
    public IActionResult ArriesgarPalabra(string Palabra)
    {
        int i = 0;
        do
        {
        Juego.ArriesgarLetra(Palabra[i], true);
        i++;
        }while(i < Palabra.Length && Juego.adivino);
        if(!Juego.adivino)
        {
           Juego.perdiste = true;
           ViewBag.perdiste = Juego.perdiste;
        }
        if(Juego.ganaste)
        {
            return RedirectToAction("Gano");
        }
        else if(Juego.perdiste)
        {
            return RedirectToAction("Perdio");
        }
        return View("Ahorcado");
    }
}
