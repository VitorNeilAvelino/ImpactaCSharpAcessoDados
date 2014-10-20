using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp2.Capitulo02.Produtos
{
    public partial class TipoProdutoForm : Form
    {
        public TipoProdutoForm()
        {
            InitializeComponent();
        }

        private void tipoProdutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tipoProdutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pedidosDataSet);

        }

        private void TipoProdutoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pedidosDataSet.TipoProduto' table. You can move, or remove it, as needed.
            this.tipoProdutoTableAdapter.Fill(this.pedidosDataSet.TipoProduto);

        }
    }
}
