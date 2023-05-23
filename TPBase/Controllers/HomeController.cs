using Microsoft.AspNetCore.Mvc;
using TPBase.Models;
namespace TPBase.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaPaises = Info.ListarPaises();
        return View();
    }

    public IActionResult DetallePais(string nombre)
    {
        ViewBag.Pais = Info.DetallePais(nombre);
        return View();
    }
}
