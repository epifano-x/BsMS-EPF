using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsMS.Classes
{
    public class Vendas
    {
        public Guid ID { get; set; }
        public string Cliente { get; set; }
        public float ValorFinal { get; set; }
        public string Itens { get; set; }
        public string Usuario { get; set; }
        public DateTime DataHora { get; set; }
        public float Valor { get; set; }
        public float Desconto { get; set; }

        public Vendas(Guid iD, string cliente, float valorFinal, string itens, string usuario, DateTime dataHora, float valor, float desconto)
        {
            ID=iD;
            Cliente=cliente;
            ValorFinal=valorFinal;
            Itens=itens;
            Usuario=usuario;
            DataHora=dataHora;
            Valor=valor;
            Desconto=desconto;
        }

        public void GerarId()
        {
            ID = Guid.NewGuid();
        }

    }
}
