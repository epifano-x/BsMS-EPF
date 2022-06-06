using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BsMS.WindowsForms.Itens
{
    public partial class CadastrarItens : Form
    {
        public CadastrarItens()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var telaCadastroFornecedor = new CadastroFornecedor();
            telaCadastroFornecedor.Show(this);
        }
    }
}
