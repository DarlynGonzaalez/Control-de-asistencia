using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Web.Mvc;

namespace Utalca.Controllers
{
    public class ProfesorController : Controller
    {
        // GET: Profesor
        public ActionResult Index()
        {
            var servicio = new ControlAsistencia.ControlAsistenciaClient();
            var cursos = servicio.Cursos();
            List<ControlAsistencia.Participante> profesores = new List<ControlAsistencia.Participante>();
             foreach (var varCursos in cursos)
            {
                var profesCurso = varCursos.Profesores;


                foreach (var profeCurso  in profesCurso)
                {
                    if (agregarProfesor(profeCurso,profesores))
                    {
                        profesores.Add(profeCurso);
                    }                  
                
                }
    
            }
           
            return View(profesores);
        }

        public Boolean agregarProfesor(ControlAsistencia.Participante profesor,List<ControlAsistencia.Participante> profesores)
        {
            foreach (var profeCurso in profesores)
            {
                if (profeCurso.Nombre==profesor.Nombre)
                {
                    return false;
                }
                else {
                    return true; }

            }

            return true;
        }

        public ActionResult Detalles(long id)
        {
            var profesor = Servicio.DatosProfesor.Profesores().FirstOrDefault(m => m.ID == id);
            if(profesor != null)
            {
                if(profesor.ID % 2 == 0)
                    return View("DetallesPicante", profesor);
                else
                    return View("DetallesPulento", profesor);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Models.Profesor p)
        {
            var profesores = Servicio.DatosProfesor.Profesores();
            if(profesores.Any(m => m.Nombre == p.Nombre))
            {
                Utils.MensajesUI.SetError("Ya existe un usuario con ese nombre");
                return RedirectToAction("Index", "Home");
            }
            else
            {
                Servicio.DatosProfesor.Profesores().Add(p);
                return RedirectToAction("Index", "Profesor");
            }
            
        }
    }
}