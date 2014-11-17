using System;
using System.Windows.Forms;
using Impacta.Repositorios.SqlServer.Proc;

namespace CSharp2.Capitulo02.Produtos
{
    public partial class RelatorioForm : Form
    {
        public RelatorioForm()
        {
            InitializeComponent();
        }

        private void RelatorioForm_Load(object sender, EventArgs e)
        {
            this.SelecionarProdutoTableAdapter.Fill(this.ProdutoDataSet.SelecionarProduto, null);
            //ProdutoBindingSource.DataSource = new ProdutoRepositorio().Selecionar();
            this.reportViewer.RefreshReport();
        }
    }
}