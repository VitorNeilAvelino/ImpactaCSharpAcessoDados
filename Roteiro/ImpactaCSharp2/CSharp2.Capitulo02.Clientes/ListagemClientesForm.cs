using System;
using System.Windows.Forms;
using Impacta.Infra.Repositorios.SqlServer;

namespace CSharp2.Capitulo02.Clientes
{
    public partial class ListagemClientesForm : Form
    {
        public ListagemClientesForm()
        {
            InitializeComponent();
        }

        private void ListagemClientesForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = nomePesquisadoToolStripTextBox.Control;
            clientesDataGridView.AutoGenerateColumns = false;
        }

        private void pesquisarToolStripButton_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            if (nomePesquisadoToolStripTextBox.Text.Trim() == string.Empty)
            {
                clientesDataGridView.DataSource = null;
                return;
            }

            clientesDataGridView.DataSource = new ClienteRepositorio().Selecionar(nomePesquisadoToolStripTextBox.Text);
        }

        private void nomePesquisadoToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar();
            }
        }
    }
}