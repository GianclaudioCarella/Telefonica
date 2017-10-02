using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonica.Business.Repositories
{
    public class TelefonoRepository : IRepository<Telefono>
    {
        private TelefonicaEntities _context;
        public TelefonoRepository(TelefonicaEntities telefonicaContext)
        {
            this._context = telefonicaContext;
        }

        public IEnumerable<Telefono> GetAll()
        {
            return _context.Telefonos.ToList();
        }

        public Telefono Get(Guid id)
        {
            return _context.Telefonos.Find(id);
        }

        public void Insert(Telefono telefono)
        {
            _context.Telefonos.Add(telefono);
        }

        public void Delete(Guid id)
        {
            Telefono tel = _context.Telefonos.Find(id);
            _context.Telefonos.Remove(tel);
        }

        public void Update(Telefono telefono)
        {
            _context.Entry(telefono).State = EntityState.Modified;
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
