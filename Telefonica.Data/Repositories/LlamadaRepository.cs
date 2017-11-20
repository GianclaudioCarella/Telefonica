using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonica.Business.Repositories
{
    public class LlamadaRepository : IRepository<Llamada>
    {
        private TelefonicaEntities _context;

        public LlamadaRepository(TelefonicaEntities telefonicaContext)
        {
            this._context = telefonicaContext;
        }

        public IEnumerable<Llamada> GetAll()
        {
            return _context.Llamadas.ToList();
        }

        public Llamada Get(Guid id)
        {
            return _context.Llamadas.Find(id);
        }

        public void Insert(Llamada Llamada)
        {
            _context.Llamadas.Add(Llamada);
        }

        public void Delete(Guid id)
        {
            Llamada tel = _context.Llamadas.Find(id);
            _context.Llamadas.Remove(tel);
        }

        public void Update(Llamada Llamada)
        {
            _context.Entry(Llamada).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
