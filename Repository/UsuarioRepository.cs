using BsMS.Classes;
using BsMS.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsMS.Repository
{
    public class UsuarioRepository : IRepository<Usuario>
    {
        public readonly EFDataContext _context;
        public UsuarioRepository(EFDataContext context)
        {
            _context = context;
        }
        public IReadOnlyCollection<Usuario> ObterTodos()
        {
            return _context.Usuario.AsNoTracking().
               OrderBy(c => c.Nome).ToList().AsReadOnly();
        }


        public Usuario Gravar(Usuario t)
        {
            if (string.IsNullOrWhiteSpace(t.Nome))
            {
                throw new Exception("Nome não pode ser em branco");
            }
            if (t.Id == null)
            {
                t.GerarId();
                _context.Usuario.Add(t);
            }
            else
            {
                _context.Update(t);
            }
            _context.SaveChanges();
            _context.Dispose();
            return t;
        }

        public Usuario ObterPorID(Guid? id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Remover(Usuario t)
        {
            _context.Usuario.Remove(t);
            _context.SaveChanges();
            _context.Dispose();
        }

        public IReadOnlyCollection<Usuario> ObterEspecificos(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
