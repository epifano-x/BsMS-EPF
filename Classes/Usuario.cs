using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsMS.Classes
{
    public class Usuario
    {
        public Guid? Id { get; set; } 
        public string Nome { get; set; }
        public int Senha { get; set; }
        public Usuario(Guid? id, string nome, int senha)
        {
            Id=id;
            Nome = nome;
            Senha = senha;
            
        }

        public void GerarId()
        {
            Id = Guid.NewGuid();
        }


    }
}
