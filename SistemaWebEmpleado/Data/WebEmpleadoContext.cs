using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SistemaWebEmpleado.Models;

namespace SistemaWebEmpleado.Data
{
    public class WebEmpleadoContext :DbContext
    {
        public WebEmpleadoContext(DbContextOptions<WebEmpleadoContext> options) : base(options) { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
