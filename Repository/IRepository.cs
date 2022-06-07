using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsMS.Repository
{
    public interface IRepository<T>
    {
        public IReadOnlyCollection<T> ObterTodos();
        public T ObterPorID(Guid? id);
        public IReadOnlyCollection<T> ObterEspecificos(Guid id);
        public T Gravar(T t);
        public void Remover(T t);
        public void Dispose();
    }
}
