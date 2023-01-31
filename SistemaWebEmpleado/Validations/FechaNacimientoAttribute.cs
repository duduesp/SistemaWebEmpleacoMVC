using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.Features;

namespace SistemaWebEmpleado.Validations
{
    public class FechaNacimientoAttribute :ValidationAttribute 
    {
        //CONSTRUCTOR
        public FechaNacimientoAttribute()
        {
            ErrorMessage = "El año de nacimiento debe ser mayor de 2000";
        }


        public override bool IsValid(object value)
        {
            DateTime fechaNacimiento = (DateTime)value;
            int year = fechaNacimiento.Year;

            if (year < 2000) return false; else return true;
        }
    }
}
