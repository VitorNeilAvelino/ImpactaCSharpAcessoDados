using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Impacta.Dominio;
using Impacta.Infra.Apoio;
using Impacta.Infra.Repositorios.SqlServer.Procedures;

namespace CSharp2.Capitulo02.Clientes
{
    public partial class ClienteForm : Form
    {
        private readonly Cliente _cliente;

        public ClienteForm()
        {
            InitializeComponent();
        }

        public ClienteForm(int clienteId)
        {
            InitializeComponent();
            
            var cliente = new ClienteRepositorio().Selecionar(clienteId);

            _cliente = cliente;

            PopularFormulario(cliente);
        }

        private void PopularFormulario(Cliente cliente)
        {
            nomeTextBox.Text = cliente.Nome;
            nascimentoMaskedTextBox.Text = cliente.DataNascimento.ToString("dd/MM/yyyy");
            emailTextBox.Text = cliente.Email;
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            if (!Formulario.ValidarCamposObrigatorios(this, clienteErrorProvider) | !Formulario.ValidarTipoDosDados(this, clienteErrorProvider))
            {
                return;
            }

            try
            {
                GravarCliente();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("ClienteEmailUk"))
                {
                    MessageBox.Show("Já existe um cliente cadastrado com este email.");
                }
                else
                {
                    ExibirMensagemDeErro(ex);
                }
            }
            catch (Exception ex)
            {
                ExibirMensagemDeErro(ex);
            }
        }

        private void GravarCliente()
        {
            if (_cliente == null)
            {
                InserirCliente();
                MessageBox.Show("Cliente gravado com sucesso!");
                Formulario.Limpar(this);
                nomeTextBox.Focus();
            }
            else
            {
                AtualizarCliente();
                this.Close();
            }
        }

        private void AtualizarCliente()
        {
            _cliente.Nome = nomeTextBox.Text;
            _cliente.DataNascimento = nascimentoMaskedTextBox.Text.ParaData();
            _cliente.Email = emailTextBox.Text;

            new ClienteRepositorio().Atualizar(_cliente);
        }

        private static void ExibirMensagemDeErro(Exception ex)
        {
            MessageBox.Show("Houve um erro e a gravação não foi realzada! O suporte já foi comunicado.");
            Logar.PorEmail(ex);
        }

        private void InserirCliente()
        {
            var conexao = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Oficina;Integrated Security=True");
            conexao.Open();

            var instrucao = string.Format("Insert Cliente(Nome, Email, DataNascimento) values('{0}', '{1}', '{2}')", nomeTextBox.Text.Trim(), emailTextBox.Text.Trim(),
                Convert.ToDateTime(nascimentoMaskedTextBox.Text).ToString("yyyy-MM-dd"));

            var comando = new SqlCommand(instrucao, conexao);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}