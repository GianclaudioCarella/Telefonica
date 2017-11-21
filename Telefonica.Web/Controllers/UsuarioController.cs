using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Telefonica.Business;
using Telefonica.Business.Repositories;
using Telefonica.Data;

namespace Telefonica.Web.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        private IRepository<Usuario> _repo;

        public UsuarioController(IRepository<Usuario> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return _repo.GetAll();
        }

        [HttpGet, Route("{id:guid}")]
        public Usuario Get(Guid id)
        {
            return _repo.Get(id);
        }

        [HttpPost, Route("new")]
        public void New(Usuario usuario)
        {
            usuario.UsuarioId = Guid.NewGuid();
            usuario.Telefono.TelefonoId = Guid.NewGuid();
            _repo.Insert(usuario);
            _repo.Save();
        }

        [HttpPost, Route("update")]
        public void UpdateUsuario(Usuario usuario)
        {
            _repo.Update(usuario);
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
