using System;
using System.Collections.Generic;
using c1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace c1.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult Index()
        {
            var reg = new Alumno(){Nombre =  "Pepe  Perez",
                                UniqueId = Guid.NewGuid().ToString()};
                
                ViewBag.Fecha = DateTime.Now;
 
            return View(reg);
        }

        public IActionResult MultiAlumno()
        {
            var lst = new Alumno();
                
                ViewBag.Fecha = DateTime.Now;
 
            return View("MultiAlumno",lst);
        }

        
    }
}