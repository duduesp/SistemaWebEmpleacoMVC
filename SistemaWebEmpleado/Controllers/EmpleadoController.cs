using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;

namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly WebEmpleadoContext context;

        public EmpleadoController(WebEmpleadoContext context)
        {
            this.context = context;
        }


        //GET empleado/index
        [HttpGet]
        public IActionResult Index()
        {
            var empleado = context.Empleados.ToList();
            return View(empleado);
        }

        //Get: Empleado/Insertar
        [HttpGet]
        public ActionResult Insertar()
        {
            Empleado empleado = new Empleado();

            return View("Insertar", empleado);
        }

        //post: Empleado/Insertar
        [HttpPost]
        public ActionResult Insertar(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
                context.Empleados.Add(empleado);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empleado);
        }

        //GET Empleado/PorTitulo/titulo
        [HttpGet("{titulo}")]
        public ActionResult<IEnumerable<Empleado>> PorTitulo(string titulo)
        {
                var empleado = (from a in context.Empleados
                                where a.Titulo == titulo
                                select a).ToList();
                return View("PorTitulo", empleado);

        }
    }
}
