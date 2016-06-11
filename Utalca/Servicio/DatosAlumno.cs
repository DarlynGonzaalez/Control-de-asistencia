using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utalca.Servicio
{
    public class DatosAlumno
    {
        public static List<Models.Alumno> alumnos()
        {
            var Alumnos = new List<Models.Alumno>();
            Alumnos.Add(new Models.Alumno() { ID = 2, Nombre = "Luis", Apellido = "Fuenzalida" });
            Alumnos.Add(new Models.Alumno() { ID = 3, Nombre = "Pablo", Apellido = "Gomez"});
            Alumnos.Add(new Models.Alumno() { ID = 4, Nombre = "Sebastian", Apellido = "Alvares" });
            Alumnos.Add(new Models.Alumno() { ID = 5, Nombre = "Darlyn", Apellido = "Gonzalez"});
            Alumnos.Add(new Models.Alumno() { ID = 6, Nombre = "Pedro", Apellido = "Ortiz"});
            Alumnos.Add(new Models.Alumno() { ID = 1, Nombre = "Juan", Apellido = "Perez" });
            return Alumnos;                                                                                                                       
        }

    }
}