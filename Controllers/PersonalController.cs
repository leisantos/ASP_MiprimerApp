using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASP_MiprimerApp.Models;

namespace ASP_MiprimerApp.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
        Personal personal = new Personal();
            personal.nombre = "Ena leidye Santos Ramirez ";
            personal.sexo = "Femenino";
            personal.direccion = " Colonia Francisco Gavidia.";
            personal.ciudad = "San Miguel";
            personal.correo = "enaleidysantosramirez0@gmail.com ";
            personal.telefono ="7050 3696 ";
            personal.carrera ="Técnico en ingeniería en sistemas y redes informáticas";
            personal.edad=23;
            personal.info= "Me considero una buena  persona y estudiante, comprensiva, dedicada y responsable. Soy dedicada a mi carrera ya que me gusta mucho el mundo de la tecnología porque podre mejorar y utilizar el pesamiento lógico para resolver problemas complejos también  comprender y desarrollar sistemas informáticos.";
            return View(personal);
        }
    }
}