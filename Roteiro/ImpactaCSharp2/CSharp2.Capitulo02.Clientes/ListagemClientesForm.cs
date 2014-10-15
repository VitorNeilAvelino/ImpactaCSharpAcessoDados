using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Impacta.Dominio;
using Impacta.Apoio;
using Impacta.Infra.Repositorios.SqlServer.Procedures;

namespace CSharp2.Capitulo02.Clientes
{
    public partial class ListagemClientesForm : Form
    {
        private readonly ClienteRepositorio _clienteRepositorio = new ClienteRepositorio();

        public ListagemClientesForm()
        {
            InitializeComponent();
        }

        private void ListagemClientesForm_Load(object sender, EventArgs e)
        {
            DefinirPropriedadesControles();
        }

        private void DefinirPropriedadesControles()
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

            clientesDataGridView.DataSource = ObterModelViewGridClientes(_clienteRepositorio.Selecionar(nomePesquisadoToolStripTextBox.Text));
        }

        private static List<GridClientesModelView> ObterModelViewGridClientes(DataTable dataTable)
        {
            var retorno = new List<GridClientesModelView>();

            foreach (DataRow registro in dataTable.Rows)
            {
                retorno.Add(new GridClientesModelView(registro));
            }

            return retorno;
        }

        private void nomePesquisadoToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Pesquisar();
            }
        }

        private void clientesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            var celulaClicada = clientesDataGridView.CurrentCell;
            var acaoFormulario = DefinirAcaoFormulario(celulaClicada);

            if (acaoFormulario == AcaoFormulario.NaoDefinida) return;

            var clienteId = Convert.ToInt32(celulaClicada.OwningRow.Cells[idClienteColumn.Index].Value);
            
            switch (acaoFormulario)
            {
                case AcaoFormulario.Editar:
                    AbrirFormularioParaEdicao(clienteId);
                    break;
                case AcaoFormulario.Excluir:
                    var resposta = MessageBox.Show("Deseja realmente excluir este Cliente?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (resposta == DialogResult.Yes)
                    {
                        _clienteRepositorio.Excluir(clienteId);
                    }
                    break;
            }

            Pesquisar();
        }

        private AcaoFormulario DefinirAcaoFormulario(DataGridViewCell celulaClicada)
        {
            if (celulaClicada.OwningColumn.Index == editarClienteColumn.Index)
            {
                return AcaoFormulario.Editar;
            }

            if (celulaClicada.OwningColumn.Index == excluirClienteColumn.Index)
            {
                return AcaoFormulario.Excluir;
            }

            return AcaoFormulario.NaoDefinida;
        }

        private static void AbrirFormularioParaEdicao(int clienteId)
        {
            var clienteForm = new ClienteForm(clienteId);
            clienteForm.ShowDialog();
        }

        private void novoToolStripButton_Click(object sender, EventArgs e)
        {
            new ClienteForm().ShowDialog();
        }

        private void imprimirToolStripButton_Click(object sender, EventArgs e)
        {
            new RelatorioClientesForm().ShowDialog();
        }
    }

    internal class GridClientesModelView
    {
        public GridClientesModelView(DataRow registro)
        {
            Id = registro["Id"].ParaInteiro();
            Nome = registro["Nome"].ToString();
            DataNascimento = registro["DataNascimento"].ParaData();
            Email = registro["Email"].ToString();
            Tipo = ((TipoCliente)registro["Tipo"]).ToString();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
    }
}