using System;
using System.Windows.Forms;
using Impacta.Repositorios.SqlServer.Proc;
using Impacta.Apoio;
using System.Data.SqlClient;

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

            try
            {
                produtosDataGridView.DataSource = _produtoRepositorio.Selecionar(descricaoToolStripTextBox.Text);
            }
            catch (Exception ex)
            {
                Global.TratarErro("Houve um erro e a pesquisa não foi realizada! O suporte já foi comunicado.", ex);
            }
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
                        ExcluirProduto(produtoId);
                    }

                    break;
            }

            Pesquisar();
        }

        private void ExcluirProduto(int produtoId)
        {
            try
            {
                _produtoRepositorio.Excluir(produtoId);
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("FK_ItensPedido_Produto"))
                {
                    MessageBox.Show("Não é possível excluir um produto que já foi incluído em um pedido.");
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                Global.TratarErro("Houve um erro e a exclusão não foi realizada! O suporte já foi comunicado.", ex);
            }
        }

        private void AbrirFormularioParaEdicao(int produtoId)
        {
            using (var produtoForm = new ProdutoForm(produtoId))
            {
                produtoForm.ShowDialog();
            }
        }

        private AcaoFormulario DefinirAcaoFormulario(DataGridViewCell celulaClicada)
        {
            if (celulaClicada.OwningColumn.Index == editarProdutoColumn.Index)
            {
                return AcaoFormulario.Editar;
            }

            if (celulaClicada.OwningColumn.Index == excluirProdutoColumn.Index)
            {
                return AcaoFormulario.Excluir;
            }

            return AcaoFormulario.NaoDefinida;
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            using (var produtoForm = new ProdutoForm())
            {
                produtoForm.ShowDialog();
            }
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            using (var relatorioForm = new RelatorioForm())
            {
                relatorioForm.ShowDialog();
            }
        }
    }
}