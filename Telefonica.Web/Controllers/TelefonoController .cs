using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Telefonica.Business;
using Telefonica.Business.Repositories;

namespace Telefonica.Web.Controllers
{
    [RoutePrefix("api/Telefono")]
    public class TelefonoController : ApiController
    {
        private IRepository<Telefono> _repo;

        public TelefonoController(IRepository<Telefono> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Telefono> Get()
        {
            return _repo.GetAll();
        }

        [HttpGet, Route("{id:guid}")]
        public Telefono Get(Guid id)
        {
            return _repo.Get(id);
        }

        [HttpPost, Route("new")]
        public void New(Telefono Telefono)
        {
            Telefono.TelefonoId = Guid.NewGuid();
            _repo.Insert(Telefono);
            _repo.Save();
        }

        [HttpPost, Route("update")]
        public void UpdateTelefono(Telefono Telefono)
        {
            _repo.Update(Telefono);
            _repo.Save();
        }

        [HttpPost, Route("delete/{id:guid}")]
        public void Delete(Guid id)
        {
            _repo.Delete(id);
            _repo.Save();
        }
    }
}
