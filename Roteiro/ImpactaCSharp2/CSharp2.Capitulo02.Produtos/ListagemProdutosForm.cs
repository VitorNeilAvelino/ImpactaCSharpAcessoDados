using System;
using System.Windows.Forms;
using Impacta.Repositorios.SqlServer.Proc;
using Impacta.Apoio;

namespace CSharp2.Capitulo02.Produtos
{
    public partial class ListagemProdutosForm : Form
    {
        private ProdutoRepositorio _produtoRepositorio = new ProdutoRepositorio();

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

            produtosDataGridView.DataSource = _produtoRepositorio.Selecionar(descricaoToolStripTextBox.Text);
        }

        private void DefinirPropriedadesControles()
        {
            this.ActiveControl = descricaoToolStripTextBox.Control;
            produtosDataGridView.AutoGenerateColumns = false;
            //produtosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void descricaoToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar();
            }
        }

        private void produtosDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var celulaClicada = produtosDataGridView.CurrentCell;
            var acaoFormulario = DefinirAcaoFormulario(celulaClicada);

            if (acaoFormulario == AcaoFormulario.NaoDefinida) return;

            var produtoId = Convert.ToInt32(celulaClicada.OwningRow.Cells[produtoIdColumn.Index].Value);

            switch (acaoFormulario)
            {
                case AcaoFormulario.Editar:
                    AbrirFormularioParaEdicao(produtoId);
                    break;
                case AcaoFormulario.Excluir:
                    var resposta = MessageBox.Show("Deseja realmente excluir este Produto?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resposta == DialogResult.Yes)
                    {
                        _produtoRepositorio.Excluir(produtoId);
                    }
                    break;
            }

            Pesquisar();
        }

        private void AbrirFormularioParaEdicao(int clienteId)
        {
            throw new NotImplementedException();
        }

        private AcaoFormulario DefinirAcaoFormulario(DataGridViewCell celulaClicada)
        {
            throw new NotImplementedException();
        }
    }
}