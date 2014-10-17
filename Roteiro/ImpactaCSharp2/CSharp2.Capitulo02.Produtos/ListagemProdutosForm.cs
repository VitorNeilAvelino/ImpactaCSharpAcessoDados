using System;
using System.Windows.Forms;
using Impacta.Infra.Repositorios.SqlServer.Procedures;
using Impacta.Repositorios.SqlServer.Proc;
using System.Collections.Generic;
using System.Data;

namespace CSharp2.Capitulo02.Produtos
{
    public partial class ListagemProdutosForm : Form
    {
        public ListagemProdutosForm()
        {
            InitializeComponent();
            DefinirPropriedadesControles();
        }

        private void pesquisarToolStripButton_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void Pesquisar()
        {
            if (descricaoToolStripTextBox.Text.Trim() == string.Empty)
            {
                produtosDataGridView.DataSource = null;
                return;
            }

            produtosDataGridView.DataSource = ObterViewModel(new ProdutoRepositorio().Selecionar(descricaoToolStripTextBox.Text));
        }

        private List<ProdutoViewModel> ObterViewModel(System.Data.DataTable dataTable)
        {
            var lista = new List<ProdutoViewModel>();

            foreach (DataRow registro in dataTable.Rows)
            {
                lista.Add(new ProdutoViewModel(registro));
            }

            return lista;
        }

        private void DefinirPropriedadesControles()
        {
            this.ActiveControl = descricaoToolStripTextBox.Control;
            produtosDataGridView.AutoGenerateColumns = false;
            produtosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void descricaoToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar();
            }
        }
    }
}