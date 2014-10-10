using Impacta.Infra.Apoio;
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
            throw new NotImplementedException();
        }
    }
}