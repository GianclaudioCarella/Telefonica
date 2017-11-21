using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Telefonica.Business;
using Telefonica.Business.Services;
using Telefonica.Data;

namespace Telefonica.Web.Controllers
{
    [RoutePrefix("api/Llamada")]
    public class LlamadaController : ApiController
    {
        private IRepository<Llamada> _repo;
        private ILlamadaService _srv;

        public LlamadaController(
            IRepository<Llamada> repo, 
            ILlamadaService srv)
        {
            _repo = repo;
            _srv = srv;
        }

        [HttpGet]
        public IEnumerable<Llamada> Get()
        {
            return _repo.GetAll();
        }

        [HttpGet, Route("{id:guid}")]
        public Llamada Get(Guid id)
        {
            return _repo.Get(id);
        }

        [HttpGet, Route("{inicio:DateTime}/{fin:DateTime}")]
        public IEnumerable<Llamada> GetRange(DateTime inicio, DateTime fin)
        {
            return _repo.GetAll().Where(l => l.InicioLlamada >= inicio && l.InicioLlamada <= fin).ToList();
        }

        [HttpGet, Route("CalculaCosto/{llamadaId:guid}")]
        public double CalculaCosto(Guid llamadaId)
        {
            return _srv.CalculaCosto(_repo.Get(llamadaId));
        }

        [HttpGet, Route("CalculaCosto/{inicio:DateTime}/{fin:DateTime}")]
        public double CalculaCostoRange(DateTime inicio, DateTime fin)
        {
            return _srv.CalculaCostoRange(inicio, fin);
        }

        [HttpPost, Route("new")]
        public void New(Llamada Llamada)
        {

            //TODO BUSCAR EL USUARIO PARA NO CREAR UNO NUEVO

            //genera guid al telefono y a la llamada
            Llamada.LlamadaId = Guid.NewGuid();

            //tel
            Guid tel = Guid.NewGuid();
            Llamada.TelefonoId = tel;
            Llamada.Telefono.TelefonoId = tel;

            // tel user
            Guid teluser = Guid.NewGuid();
            Llamada.Usuario.TelefonoId = teluser;
            Llamada.Usuario.Telefono.TelefonoId = teluser;

            // user
            Guid user = Guid.NewGuid();
            Llamada.UsuarioId = user;
            Llamada.Usuario.UsuarioId = user;

            _repo.Insert(Llamada);
            _repo.Save();
        }

        [HttpPost, Route("update")]
        public void UpdateLlamada(Llamada Llamada)
        {
            _repo.Update(Llamada);
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
