using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utalca.Servicio
{
    public class DatosProfesor
    {
        public static List<Models.Profesor> Profesores()
        {
            var profesores = new List<Models.Profesor>();
            profesores.Add(new Models.Profesor() { ID = 1, Nombre = "Edgardo1", Apellido = "Ortiz1", Biografia = "Es el mejor", SitioWeb = "www.utalca.cl" });
            profesores.Add(new Models.Profesor() { ID = 2, Nombre = "Edgardo2", Apellido = "Ortiz2", Biografia = "Es el mejor", SitioWeb = "www.utalca.cl" });
            profesores.Add(new Models.Profesor() { ID = 3, Nombre = "Edgardo3", Apellido = "Ortiz3", Biografia = "Es el mejor", SitioWeb = "www.utalca.cl" });
            profesores.Add(new Models.Profesor() { ID = 4, Nombre = "Edgardo4", Apellido = "Ortiz4", Biografia = "Es el mejor", SitioWeb = "www.utalca.cl" });
            profesores.Add(new Models.Profesor() { ID = 5, Nombre = "Edgardo5", Apellido = "Ortiz5", Biografia = "Es el mejor", SitioWeb = "www.utalca.cl" });
            profesores.Add(new Models.Profesor() { ID = 6, Nombre = "Edgardo6", Apellido = "Ortiz6", Biografia = "Es el mejor", SitioWeb = "www.utalca.cl" });
            return profesores;
        }

    }
}