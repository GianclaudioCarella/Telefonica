using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonica.Business.Repositories
{
    public class UsuarioRepository : IRepository<Usuario>
    {
        private TelefonicaEntities _context;
        public UsuarioRepository(TelefonicaEntities telefonicaContext)
        {
            this._context = telefonicaContext;
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario Get(Guid id)
        {
            return _context.Usuarios.Find(id);
        }

        public void Insert(Usuario Usuario)
        {
            _context.Usuarios.Add(Usuario);
        }

        public void Delete(Guid id)
        {
            Usuario tel = _context.Usuarios.Find(id);
            _context.Usuarios.Remove(tel);
        }

        public void Update(Usuario Usuario)
        {
            _context.Entry(Usuario).State = EntityState.Modified;
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
