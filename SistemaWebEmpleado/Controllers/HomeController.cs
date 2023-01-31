using System;
using Microsoft.AspNetCore.Mvc;

namespace SistemaWebEmpleado.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Bienvenido al sistema de Médicos.";
            ViewBag.Fecha = DateTime.Now.ToString();
            return View();
        }
    }
}
