using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsMS.Classes
{
    public class Fornecedor
    {

        public string Nome { get; set; }
        public Guid? Id { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
        public string Estado { get; set; }
        public string Complemento { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
       
        public int Telefone { get; set; }
        public string Email { get; set; }

        public Fornecedor(Guid? id, string nome, string cidade, string rua, int numero, int cep, string estado, string complemento, string cpf, string cnpj, int telefone, string email)
        {
            Id= id;
            Nome = nome;
            Cidade = cidade;
            Rua = rua;
            Numero = numero;
            Cep = cep;
            Estado = estado;
            Complemento = complemento;
            Cpf = cpf;
            Cnpj = cnpj;
            
            Telefone = telefone;
            Email = email;


        }
        public void GerarId()
        {
            Id = Guid.NewGuid();
        }

    }
}
