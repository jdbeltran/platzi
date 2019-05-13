using System;
using System.Collections.Generic;
using c1.Models;
using Microsoft.AspNetCore.Mvc;

namespace c1.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult Index()
        {
            var asignatura = new Asignatura()
            {
                Nombre = "Matematica",
                UniqueId = Guid.NewGuid().ToString()
            };

            ViewBag.Fecha = DateTime.Now;

            return View(asignatura);
        }

        public IActionResult MultiAsignatura()
        {


            ViewBag.Fecha = DateTime.Now;
            List<Asignatura> lstAsignatura = new List<Asignatura>();

            return View("MultiAsignatura", lstAsignatura);
        }

    }
}