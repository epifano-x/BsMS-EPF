using BsMS.Classes;
using BsMS.Data;
using BsMS.Repository;
using BsMS.WindowsForms;
using BsMS.WindowsForms.Itens;
using BsMS.WindowsForms.Vendas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BsMS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        public IRepository<Itens>? _itensRepository;

        private void InicializarFormulario()
        {
            _itensRepository = new ItensRepository(new EFDataContext());
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label1.Text =  "usuario";
            InicializarFormulario();
            var Lista = _itensRepository.ObterTodos();
            dataGridView1.DataSource = Lista;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cADASTRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastrarusuario = new CadastroUsuario();
            cadastrarusuario.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var telaCadastrarCliente = new CadastroCliente();
            telaCadastrarCliente.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var telaCadastroUsuario = new CadastroUsuario();
            telaCadastroUsuario.Show();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            var telaEditarCliente = new EditarCliente();
            telaEditarCliente.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var telaEditarFornecedor = new EditarFornecedor();
            telaEditarFornecedor.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var telaEditarUsuario = new EditarUsuario();
            telaEditarUsuario.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var telaCadastrarItem = new CadastrarItens();
            telaCadastrarItem.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var telaCadastrarFornecedor = new CadastroFornecedor();
            telaCadastrarFornecedor.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var telaEditarItem = new EditarItens();
            telaEditarItem.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var telaRemovertens = new RemoverItens();
            telaRemovertens.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var telaCriarVenda = new CriarVenda();
            telaCriarVenda.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            var telaEditarVenda = new EditarVenda();
            telaEditarVenda.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var telaRemoverVenda = new RemoverVenda();
            telaRemoverVenda.Show();
        }

        private void itensBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
