using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Telefonica.Business;
using Telefonica.Business.Enums;
using Telefonica.Business.Repositories;
using Telefonica.Business.Services;

namespace Telefonica.Web.Controllers
{
    [RoutePrefix("api/Llamada")]
    public class LlamadaController : ApiController
    {
        LlamadaRepository repo = new LlamadaRepository(new TelefonicaEntities());
        LlamadaService srv = new LlamadaService();

        [HttpGet]
        public IEnumerable<Llamada> Get()
        {
            return repo.GetAll();
        }

        [HttpGet, Route("{id:guid}")]
        public Llamada Get(Guid id)
        {
            return repo.Get(id);
        }

        [HttpGet, Route("{inicio:DateTime}/{fin:DateTime}")]
        public IEnumerable<Llamada> GetRange(DateTime inicio, DateTime fin)
        {
            return repo.GetAll().Where(l => l.InicioLlamada >= inicio && l.InicioLlamada <= fin).ToList();
        }

        [HttpGet, Route("CalculaCosto/{llamadaId:guid}")]
        public double CalculaCosto(Guid llamadaId)
        {
            return srv.CalculaCosto(repo.Get(llamadaId));
        }

        [HttpGet, Route("CalculaCosto/{inicio:DateTime}/{fin:DateTime}")]
        public double CalculaCostoRange(DateTime inicio, DateTime fin)
        {
            return srv.CalculaCostoRange(inicio, fin);
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

            repo.Insert(Llamada);
            repo.Save();
        }

        [HttpPost, Route("update")]
        public void UpdateLlamada(Llamada Llamada)
        {
            repo.Update(Llamada);
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
