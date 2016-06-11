using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Utalca.Controllers
{
    public class ProfesorApiController : ApiController
    {
        // GET: api/ProfesorApi
        public IEnumerable<Models.Profesor> Get()
        {
            return Servicio.DatosProfesor.Profesores();
        }

        // GET: api/ProfesorApi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProfesorApi
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ProfesorApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ProfesorApi/5
        public void Delete(int id)
        {
        }
    }
}
