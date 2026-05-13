using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TrabajoPractico2.Models;

namespace TrabajoPractico2.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult GenerarReceta(Receta receta)
    {
        ViewBag.nombre = receta.nombre;
        ViewBag.fechaNacimiento = receta.fechaNacimiento;
        ViewBag.tipoComida = receta.tipoComida;
        ViewBag.presupuesto = receta.presupuesto;
        ViewBag.cantPersonas = receta.cantPersonas;
        return View("Resultado");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
