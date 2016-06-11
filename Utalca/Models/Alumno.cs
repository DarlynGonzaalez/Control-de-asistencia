using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Utalca.Models
{
    public class Alumno
    {
        private int edad = 0;

        public Alumno()
        {
            this.FechaNacimiento = new DateTime(1985, 5, 26);
        }

        public long ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }  


        public DateTime FechaNacimiento { get; private set; }

        public int Edad
        {
            get
            {
                this.edad = Convert.ToInt32((DateTime.Now - this.FechaNacimiento).TotalDays / 365);
                return this.edad;
            }

        }


    }
}