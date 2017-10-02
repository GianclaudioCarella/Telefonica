using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Telefonica.Business.Repositories;

namespace Telefonica.Web.Controllers
{
  [RoutePrefix("api/Llamada")]
  public class LlamadaController : ApiController
  {
    LlamadaRepository repo = new LlamadaRepository(new TelefonicaEntities());

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
      return repo.GetAll().Where(l=>l.InicioLlamada >= inicio && l.InicioLlamada <= fin).ToList();
    }

    [HttpPost, Route("new")]
    public void New(Llamada Llamada)
    {
      Llamada.LlamadaId = Guid.NewGuid();
      Llamada.Telefono.TelefonoId = Guid.NewGuid();
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
