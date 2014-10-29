using Impacta.Apoio;
using Impacta.Dominio;
using Impacta.Repositorios.SqlServer.Proc;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSharp2.Capitulo02.Produtos
{
    public partial class ProdutoForm : Form
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private Produto _produto;
        private ProdutoRepositorio _produtoRepositorio = new ProdutoRepositorio();

        public ProdutoForm()
        {
            InitializeComponent();
        }

        public ProdutoForm(int produtoId)
            : this()
        {
            try
            {
                //_produto = new ProdutoRepositorio().Selecionar(produtoId);
                _produto = _produtoRepositorio.Selecionar(produtoId);
                PopularFormulario(_produto);
            }
            catch (Exception ex)
            {
                Global.TratarErro("Ooops!", ex);
            }
        }

        private void PopularFormulario(Produto produto)
        {
            descricaoTextBox.Text = produto.Descricao;
            custoTextBox.Text = produto.Custo.ToString();
        }

        private void gravarButton_Click(object sender, EventArgs e)
        {
            if (!Formulario.ValidarCamposObrigatorios(this, produtoErrorProvider) || !Formulario.ValidarTipoDosDados(this, produtoErrorProvider))
            {
                return;
            }

            try
            {
                GravarProduto();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UK_Produto_Descricao"))
                {
                    MessageBox.Show("Já existe um produto cadastrado com esta descrição e tipo.");
                }
                else
                {
                    throw;
                }
            }
            catch (Exception ex)
            {
                TratarErro(ex);
            }
        }

        private void TratarErro(Exception ex)
        {
            MessageBox.Show("Houve um erro e a gravação não foi realizada! O suporte já foi comunicado.");
            //Logar.PorEmail(ex);
            _log.Error(ex);
        }

        private void GravarProduto()
        {
            if (_produto == null)
            {
                InserirProduto();
                MessageBox.Show("Produto gravado com sucesso!");
                Formulario.Limpar(this);
                descricaoTextBox.Focus();
            }
            else
            {
                AtualizarProduto();
                this.Close();
            }
        }

        private void AtualizarProduto()
        {
            _produto.Descricao = descricaoTextBox.Text;
            _produto.Custo = Convert.ToDecimal(custoTextBox.Text);
            _produto.Tipo.Id = Convert.ToInt32(tipoComboBox.SelectedValue);

            //new ProdutoRepositorio().Atualizar(_produto);
            _produtoRepositorio.Atualizar(_produto);
        }

        private void InserirProduto()
        {
            //var conexao = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Pedidos;Integrated Security=True");
            //var conexao = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Pedidos;uid=PedidosApp;Password=123");
            var conexao = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=Pedidos;User Id=PedidosApp;Password=123");
            conexao.Open();

            var instrucao = "Insert Produto(Descricao, TipoProduto_Id, Custo) values(@Descricao, @TipoProduto_Id, @Custo)";

            var comando = new SqlCommand(instrucao, conexao);

            comando.Parameters.AddWithValue("@Descricao", descricaoTextBox.Text.Trim());
            comando.Parameters.AddWithValue("@TipoProduto_Id", tipoComboBox.SelectedValue);
            comando.Parameters.AddWithValue("@Custo", Convert.ToDecimal(custoTextBox.Text.Trim()));

            comando.ExecuteNonQuery();

            conexao.Close();
        }

        private void custoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;
            }
        }

        private void ProdutoForm_Load(object sender, EventArgs e)
        {
            this.tipoProdutoTableAdapter.Fill(this.pedidosDataSet.TipoProduto);

            if (_produto == null)
            {
                tipoComboBox.SelectedIndex = -1;
            }
            else
            {
                tipoComboBox.SelectedValue = _produto.Tipo.Id;
            }
        }
    }
}