using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Utalca.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            var alumnos = Servicio.DatosAlumno.alumnos();
            return View(alumnos);
        }
    }
}