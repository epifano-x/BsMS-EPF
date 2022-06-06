using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsMS.Classes

{
    public class Admin
    {
        public string Nome { get; set; }
        public string Senha { get; set; }
        

        public Admin(string nome, string senha)
        {
            Nome = nome;
            Senha = senha;
        }
        public void AlterarNome(string novoNome)
        {
            Nome = novoNome;
        }

        public void AlterarEndereco(string novaSenha)
        {
            Senha = novaSenha;
        }

    }
}
