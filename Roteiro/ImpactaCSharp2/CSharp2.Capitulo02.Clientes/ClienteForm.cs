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

        public ClienteForm(int clienteId) : this()
        {
            //InitializeComponent();
            
            _cliente = new ClienteRepositorio().Selecionar(clienteId);

            PopularFormulario(_cliente);
        }

        private void PopularFormulario(Cliente cliente)
        {
            nomeEnterTextBox.Text = cliente.Nome;
            nascimentoEnterMaskedTextBox.Text = cliente.DataNascimento.ToString("dd/MM/yyyy");
            emailEnterTextBox.Text = cliente.Email;
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            if (!Formulario.ValidarCamposObrigatorios(this, clienteErrorProvider) || !Formulario.ValidarTipoDosDados(this, clienteErrorProvider))
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
                nomeEnterTextBox.Focus();
            }
            else
            {
                AtualizarCliente();
                this.Close();
            }
        }

        private void AtualizarCliente()
        {
            _cliente.Nome = nomeEnterTextBox.Text;
            _cliente.DataNascimento = nascimentoEnterMaskedTextBox.Text.ParaData();
            _cliente.Email = emailEnterTextBox.Text;

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
            //var conexao = new SqlConnection("Data Source=.;Initial Catalog=Oficina;Persist Security Info=True;User ID=oficinausuario;Password=oficina123");
            //Data Source=.;Initial Catalog=Oficina;Persist Security Info=True;User ID=oficinausuario;Password=***********
            conexao.Open();

            var instrucao = string.Format("Insert Cliente(Nome, Email, DataNascimento, Tipo) values('{0}', '{1}', '{2}', 0)", nomeEnterTextBox.Text.Trim(), emailEnterTextBox.Text.Trim(),
                Convert.ToDateTime(nascimentoEnterMaskedTextBox.Text).ToString("yyyy-MM-dd"));

            var comando = new SqlCommand(instrucao, conexao);
            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}