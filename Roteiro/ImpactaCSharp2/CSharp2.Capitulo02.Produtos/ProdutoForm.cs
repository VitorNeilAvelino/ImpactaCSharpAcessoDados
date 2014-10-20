using Impacta.Apoio;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CSharp2.Capitulo02.Produtos
{
    public partial class ProdutoForm : Form
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ProdutoForm()
        {
            InitializeComponent();
            log4net.Config.XmlConfigurator.Configure();
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
                MessageBox.Show("Produto gravado com sucesso!");
                Formulario.Limpar(this);
                descricaoTextBox.Focus();
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("UK_Produto_Descricao"))
                {
                    MessageBox.Show("Já existe um produto cadastrado com esta descrição e tipo.");
                }
                else
                {
                    TratarErro(ex);
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
            tipoComboBox.SelectedIndex = -1;
        }
    }
}