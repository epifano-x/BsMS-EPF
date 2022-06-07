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
    public class ItensRepository : IRepository<Itens>
    {
        public readonly EFDataContext _context;
        public ItensRepository(EFDataContext context)
        {
            _context = context;
        }
        public IReadOnlyCollection<Itens> ObterTodos()
        {
            return _context.Itens.AsNoTracking().
               OrderBy(c => c.Nome).ToList().AsReadOnly();
        }


        public Itens Gravar(Itens t)
        {
            if (string.IsNullOrWhiteSpace(t.Nome))
            {
                throw new Exception("Nome não pode ser em branco");
            }
            if (t.Id == null)
            {
                t.GerarId();
                _context.Itens.Add(t);
            }
            else
            {
                _context.Update(t);
            }
            _context.SaveChanges();
            _context.Dispose();
            return t;
        }

        public Itens ObterPorID(Guid? id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Remover(Itens t)
        {
            _context.Itens.Remove(t);
            _context.SaveChanges();
            _context.Dispose();
        }

        public IReadOnlyCollection<Itens> ObterEspecificos(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
