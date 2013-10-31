using System;
using System.Windows.Forms;
using Impacta.Infra.Repositorios.SqlServer.Procedures;

namespace CSharp2.Capitulo02.Clientes
{
    public partial class RelatorioClientesForm : Form
    {
        public RelatorioClientesForm()
        {
            InitializeComponent();
        }

        private void RelatorioClientesForm_Load(object sender, EventArgs e)
        {
            ClienteBindingSource.DataSource = new ClienteRepositorio().Selecionar();
            this.clientesReportViewer.RefreshReport();
        }
    }
}