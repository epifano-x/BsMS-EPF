using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsMS.Classes
{
    public class Itens
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
        //public float ValorDeEntrada { get; set; }
        //public float ValorDeVenda { get; set; }
        public int Quantidade { get; set; }
        public string Fornecedor { get; set; }
       
        public char Usuario { get; set; }   

        public Itens(Guid? id, string nome, /*float valordeentrada, float valordevenda,*/ int quantidade, string fornecedor, char usuario)
        {
            Id=id;
            Nome = nome;
            //ValorDeEntrada = valordeentrada;
            //ValorDeVenda = valordevenda;
            Quantidade = quantidade;    
            
            Usuario = usuario;
            Fornecedor = fornecedor;
            
        }

        public void GerarId()
        {
            Id = Guid.NewGuid();
        }

    }
}
