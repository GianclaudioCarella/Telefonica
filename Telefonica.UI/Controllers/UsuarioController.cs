using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Telefonica.Business.Repositories;

namespace Telefonica.UI.Controllers
{
    [RoutePrefix("api/Usuario")]
    public class UsuarioController : ApiController
    {
        // GET: api/Usuario
        //public IEnumerable<Usuario> Get()
        //{
        //    UsuarioRepository repo = new UsuarioRepository(new TelefonicaEntities());
        //    return repo.GetAll();
        //}

        [HttpGet, Route("/get")]
        // GET: api/Usuario/5
        public string Get()
        {
            return "value";
        }

        // POST: api/Usuario
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
