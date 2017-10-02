using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Telefonica.Business.Repositories;

namespace Telefonica.Web.Controllers
{
    [RoutePrefix("api/Telefono")]
    public class TelefonoController : ApiController
    {
        TelefonoRepository repo = new TelefonoRepository(new TelefonicaEntities());

        [HttpGet]
        public IEnumerable<Telefono> Get()
        {
            return repo.GetAll();
        }

        [HttpGet, Route("{id:guid}")]
        public Telefono Get(Guid id)
        {
            return repo.Get(id);
        }

        [HttpPost, Route("new")]
        public void New(Telefono Telefono)
        {
            Telefono.TelefonoId = Guid.NewGuid();
            repo.Insert(Telefono);
            repo.Save();
        }

        [HttpPost, Route("update")]
        public void UpdateTelefono(Telefono Telefono)
        {
            repo.Update(Telefono);
            repo.Save();
        }

        [HttpPost, Route("delete/{id:guid}")]
        public void Delete(Guid id)
        {
            repo.Delete(id);
            repo.Save();
        }
    }
}
