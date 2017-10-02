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
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        UsuarioRepository repo = new UsuarioRepository(new TelefonicaEntities());

        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return repo.GetAll();
        }

        [HttpGet, Route("{id:guid}")]
        public Usuario Get(Guid id)
        {
            return repo.Get(id);
        }

        [HttpPost, Route("new")]
        public void New(Usuario usuario)
        {
            usuario.UsuarioId = Guid.NewGuid();
            usuario.Telefono.TelefonoId = Guid.NewGuid();
            repo.Insert(usuario);
            repo.Save();
        }

        [HttpPost, Route("update")]
        public void UpdateUsuario(Usuario usuario)
        {
            repo.Update(usuario);
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
